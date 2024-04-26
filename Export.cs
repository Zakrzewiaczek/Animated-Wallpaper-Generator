using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Animated_Wallpaper_Creator
{
    public static class Export
    {
        public static void ExportFile(string filePath, DataGridView tabela)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath);
                streamWriter.WriteLine("Add-Type -AssemblyName System.Drawing\n");

                #region Dodawanie zmiennych z kolorami HEX

                for (int row = 0; row < tabela.Rows.Count; row++) 
                {
                    int r = int.Parse((string)tabela.Rows[row].Cells[1].Value);
                    int g = int.Parse((string)tabela.Rows[row].Cells[2].Value);
                    int b = int.Parse((string)tabela.Rows[row].Cells[3].Value);

                    string hex = String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);

                    streamWriter.WriteLine($"$text{row+1} = \"{hex}\"");
                }

                streamWriter.WriteLine();

                #endregion
                #region Dodawanie zmiennych z Color <= HEX

                for (int row = 0; row < tabela.Rows.Count; row++)
                    streamWriter.WriteLine($"$brush_text{row + 1} = New-Object System.Drawing.SolidBrush(([System.Drawing.ColorTranslator]::FromHtml($text{row+1})))");

                streamWriter.WriteLine();

                #endregion

                #region First data

                streamWriter.WriteLine(@"
function make_wallpaper {
$year = (Get-Date).Year
$month = (Get-Date).Month.ToString(""00"")
$day = (Get-Date).Day.ToString(""00"")
$day_of_the_week = (Get-Date).DayOfWeek
$hour = (Get-Date).Hour.ToString(""00"")
$minute = (Get-Date).Minute.ToString(""00"")
$second = (Get-Date).Second.ToString(""00"")
                                        
cd $home
try { del.png } catch { }

$filename = ""$home\.png"" 

$bmp = New-Object System.Drawing.Bitmap 1920,1080 
$font = New-Object System.Drawing.Font Consolas,24

$graphics = [System.Drawing.Graphics]::FromImage($bmp) 
$graphics.FillRectangle($brushBg,0,0,$bmp.Width,$bmp.Height)
");

                #endregion

                #region Wpisywanie tekstu z tabeli

                for(int i = 1; i <= tabela.Rows.Count; i++)
                {
                    var cell = tabela.Rows[i - 1].Cells[0];
                    streamWriter.WriteLine($"$graphics.DrawString(\"{cell.Value.ToString().Replace(@"\n", "`n")}\", $font, $brush_text{i}, {i*10}, 10)");
                }

                /*
                $graphics.DrawString("`n class", $font, $class_color, 10, 10)
                 */

                #endregion

                #region Saving file and showing message

                streamWriter.Flush();
                streamWriter.Close();

                MessageBox.Show("File saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show($"File not saved\nError: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
        }
    }
}
