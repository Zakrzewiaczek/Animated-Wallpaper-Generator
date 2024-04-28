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


        private bool IsHEX(string val)
        {
            Regex hexColorRegex = new Regex("^[#]?(?:[0-9a-fA-F]{3}){1,2}$");

            return hexColorRegex.IsMatch(val);
        }

        
        private void chooseColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;

                string colorHEX =
                    color.R.ToString("X2") + 
                    color.G.ToString("X2") + 
                    color.B.ToString("X2");

                Clipboard.SetText(colorHEX);

                MessageBox.Show("Color copied to clipboard", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup");

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Export.ExportFile(filePath, tabela, bg_color.Text);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            isHEX_bg(sender, e);

            tabela.Rows.Add();
            
            if(enter.Checked)
                tabela.Rows[tabela.Rows.Count - 1].Cells[0].Value = @"\n";

            tabela.Rows[tabela.Rows.Count - 1].Cells[1].Value = enter.Checked ? "#000000" : "#FFFFFF";
        }
        
        private void isHEX_bg(object sender, EventArgs e)
        {
            if (!IsHEX(bg_color.Text))
            {
                MessageBox.Show("Value is incorrect!", "HEX color error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bg_color.Text = "000000";
            }
        }

        private void bg_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
                isHEX_bg(sender, e);
        }

        private void isHex_tabela(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                var cell = tabela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (!IsHEX((string)cell.Value))
                {
                    MessageBox.Show("Value is incorrect!", "HEX color error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cell.Value = "#000000";
                }

                else
                    cell.Value = "#" + ((string)cell.Value).Replace("#", "").ToUpper();
            }
        }

        private void tabela_RemoveHash(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                var cell = tabela.Rows[e.RowIndex].Cells[1];

                string val = ((string)cell.Value).Replace("#", "");
                cell.Value = val;
            }
        }
    }
}
