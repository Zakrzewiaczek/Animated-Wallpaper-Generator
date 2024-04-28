using System;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Animated_Wallpaper_Creator
{
    public partial class Export : Form
    {
        public static void ExportFile(string filePath, DataGridView tabela, string bgHEX)
        {
            //const int MAX_LINE_LENGHT = 115;
            StreamWriter streamWriter = new StreamWriter(filePath);

            try
            {
                streamWriter.WriteLine("Add-Type -AssemblyName System.Drawing\n");

                #region Dodawanie zmiennych z kolorami HEX

                for (int row = 0; row < tabela.Rows.Count; row++) 
                {
                    string hex = (string)tabela.Rows[row].Cells[1].Value;
                    streamWriter.WriteLine($"$text{row+1} = \"{hex}\"");
                }

                streamWriter.WriteLine($"\n$BgColor = \"{"#" + (bgHEX.Replace("#", ""))}\"\n");


                #endregion
                #region Dodawanie zmiennych z Color <= HEX i brushBg

                for (int row = 0; row < tabela.Rows.Count; row++)
                    streamWriter.WriteLine($"$brush_text{row + 1} = New-Object System.Drawing.SolidBrush(([System.Drawing.ColorTranslator]::FromHtml($text{row+1})))");

                streamWriter.WriteLine("\n$brushBg = New-Object System.Drawing.SolidBrush(([System.Drawing.ColorTranslator]::FromHtml($BgColor)))\n");

                #endregion

                #region First data

                streamWriter.WriteLine(@"
function make_wallpaper {

############     Variables    ######################

$year = (Get-Date).Year

$dayOfTheWeekW = (Get-Date).DayOfWeek
$monthW = (Get-Date).ToString(""MMMM"")

$dayOfTheWeek = (((Get-Date).DayOfWeek.value__) % 7) - 1
if ($dayOfTheWeek -eq -1) { $dayOfTheWeek = 7 }

$month = (Get-Date).Month.ToString()
$day = (Get-Date).Day.ToString()
$hour_24 = (Get-Date).Hour.ToString()
$hour_12 = (Get-Date).ToString('h tt')
$minute = (Get-Date).Minute.ToString()
$second = (Get-Date).Second.ToString()

$month_0 = (Get-Date).Month.ToString(""00"")
$day_0 = (Get-Date).Day.ToString(""00"")
$hour_24_0 = (Get-Date).Hour.ToString(""00"")
$hour_12_0 = (Get-Date).ToString(""hh tt"")
$minute_0 = (Get-Date).Minute.ToString(""00"")
$second_0 = (Get-Date).Second.ToString(""00"")
$dayOfTheWeek_0 = $dayOfTheWeek.ToString(""00"")

#####################################################
                                        
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

                int howManyEnters = 0;

                for(int i = 1; i <= tabela.Rows.Count; i++)
                {
                    var cell = tabela.Rows[i - 1].Cells[0];

                    int y_pos = howManyEnters * 40;
                    howManyEnters += cell.Value.ToString().Split(new string[] { @"\n" }, StringSplitOptions.None).Length - 1;


                    string cellContent = cell.Value.ToString().Replace(@"\n", "`n");

                    streamWriter.WriteLine($"$graphics.DrawString(\"{TextToBash(cellContent)}\", $font, $brush_text{i}, 10, {y_pos})");
                }

                #endregion

                #region Second data

                streamWriter.WriteLine(@"

$graphics.Dispose() 
$bmp.Save($filename) 

Function Set-WallPaper {
param (
    [parameter(Mandatory=$True)]
    # Provide path to image
    [string]$Image,
    # Provide wallpaper style that you would like applied
    [parameter(Mandatory=$False)]
    [ValidateSet('Fill', 'Fit', 'Stretch', 'Tile', 'Center', 'Span')]
    [string]$Style)
$WallpaperStyle = Switch ($Style) {
    ""Center"" {""0""}}
If($Style -eq ""Tile"") {
    New-ItemProperty -Path ""HKCU:\Control Panel\Desktop"" -Name WallpaperStyle -PropertyType String -Value $WallpaperStyle -Force
    New-ItemProperty -Path ""HKCU:\Control Panel\Desktop"" -Name TileWallpaper -PropertyType String -Value 1 -Force
}
Else {
    New-ItemProperty -Path ""HKCU:\Control Panel\Desktop"" -Name WallpaperStyle -PropertyType String -Value $WallpaperStyle -Force
    New-ItemProperty -Path ""HKCU:\Control Panel\Desktop"" -Name TileWallpaper -PropertyType String -Value 0 -Force}
Add-Type -TypeDefinition @"" 
using System; 
using System.Runtime.InteropServices;
public class Params { 
    [DllImport(""User32.dll"",CharSet=CharSet.Unicode)] 
    public static extern int SystemParametersInfo (Int32 uAction, 
                                                   Int32 uParam, 
                                                   String lpvParam, 
                                                   Int32 fuWinIni);}
""@ 
    $SPI_SETDESKWALLPAPER = 0x0014
    $UpdateIniFile = 0x01
    $SendChangeEvent = 0x02
    $fWinIni = $UpdateIniFile -bor $SendChangeEvent
    $ret = [Params]::SystemParametersInfo($SPI_SETDESKWALLPAPER, 0, $Image, $fWinIni)}

Set-WallPaper -Image $filename -Style Center
}


while($true) {
   make_wallpaper
   timeout 1
}
");

                #endregion

                #region Saving file and showing message

                streamWriter.Flush();
                streamWriter.Close();

                MessageBox.Show("File saved succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            catch (Exception e)
            {
                #region Error => Show

                MessageBox.Show($"File not saved\nError: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (File.Exists(filePath))
                {
                    try 
                    {
                        streamWriter.Flush();
                        streamWriter.Close();

                        File.Delete(filePath); 
                    } 
                    catch (Exception) {}
                }

                #endregion
            }
        }

        private static string TextToBash(string input)
        {
            string pattern = @"\\?\{.*?\}";
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (match.Value.StartsWith("\\"))
                {
                    input = input.Replace(match.Value, match.Value.TrimStart('\\'));
                }

                else
                {
                    Dictionary<string, string> commands = new Dictionary<string, string>()
                    {
                        { "{YEAR}",          "$year"          },
                        { "{MONTH}",         "$month"         },
                        { "{MONTH_W}",       "$monthW"        },
                        { "{DAY_OF_WEEK}",   "$dayOfTheWeek"  },
                        { "{DAY_OF_WEEK_W}", "$dayOfTheWeekW" },
                        { "{DAY}",           "$day"           },
                        { "{HOUR_12}",       "$hour_12"       },
                        { "{HOUR_24}",       "$hour_24"       },
                        { "{MINUTE}",        "$minute"        },
                        { "{SECOND}",        "$second"        },
                    };

                    string expressionContent = match.Value.Trim('{', '}');
                    string contentChanges = "", returned;

                    try
                    {
                        returned = commands[match.Value.Replace("[0]", "")];
                    }
                    catch (KeyNotFoundException)
                    {
                        throw new NotImplementedException($"Zawartość wyrażenia jest niepoprawna: {match.Value}");
                    }

                    if (expressionContent.StartsWith("[0]") &&
                        expressionContent != "YEAR" &&
                        expressionContent != "MONTH_W" &&
                        expressionContent != "DAY_OF_WEEK_W")
                        returned += "_0";

                    contentChanges = returned;

                    input = input.Replace(match.Value, contentChanges);
                }
            }

            return input;
        }
    }
}
