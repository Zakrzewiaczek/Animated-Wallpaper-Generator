using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Animated_Wallpaper_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValueChangedInTabela(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex >= 0 && e.ColumnIndex < 4)
            {
                int value = Int32.Parse((string)tabela.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (value > 255 || value < 0)
                {
                    MessageBox.Show("The value must be in the range 0-255", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    tabela.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                }
            }
        }

        private static int[] HexToRGB(string hexColor)
        {
            hexColor = hexColor.Replace("#", "");
            
            if (hexColor.Length != 6)
                throw new Exception("Nieprawidłowy kolor hex!");

            int r = int.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int g = int.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int b = int.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            return new int[] { r, g, b };
        }

        private void convert_Click(object sender, EventArgs e)
        {
            string hexColor = hex_color.Text;
            rgb_out_lbl.Text = $"R: {HexToRGB(hexColor)[0]}   G: {HexToRGB(hexColor)[1]}   B: {HexToRGB(hexColor)[2]}";
        }
        
        private void chooseColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;

                hex_color.Text =
                    color.R.ToString("X2") + 
                    color.G.ToString("X2") + 
                    color.B.ToString("X2");

                convert_Click(sender, e);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup");

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Export.ExportFile(filePath, tabela);
            }
        }

        private void CheckIsHEX(object sender, EventArgs e)
        {
            Regex hexColorRegex = new Regex("^#(?:[0-9a-fA-F]{3}){1,2}$");

            if (!hexColorRegex.IsMatch("#" + hex_color.Text))
            {
                MessageBox.Show("Value is incorrect!", "HEX color error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hex_color.Text = "000000";
            }

            convert_Click(sender, e);
        }

        private void CheckIsEnter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
                CheckIsHEX(sender, e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            tabela.Rows.Add();
            tabela.Rows[tabela.Rows.Count - 1].Cells[4].Value = "Left";

            for (int i = 1; i <= 3; i++)
                tabela.Rows[tabela.Rows.Count - 1].Cells[i].Value = "0";

            if(enter.Checked)
                tabela.Rows[tabela.Rows.Count - 1].Cells[0].Value = @"\n";
        }
    }
}
