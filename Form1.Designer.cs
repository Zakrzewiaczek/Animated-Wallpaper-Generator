namespace Animated_Wallpaper_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.hex_lbl = new System.Windows.Forms.Label();
            this.hex_char = new System.Windows.Forms.Label();
            this.rgb_out_lbl = new System.Windows.Forms.Label();
            this.chooseColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.hex_color = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.add = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.green = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAlign = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToOrderColumns = true;
            this.tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabela.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.red,
            this.green,
            this.blue,
            this.textAlign});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle21;
            this.tabela.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tabela.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tabela.Location = new System.Drawing.Point(14, 15);
            this.tabela.Margin = new System.Windows.Forms.Padding(4);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(905, 474);
            this.tabela.TabIndex = 0;
            this.tabela.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValueChangedInTabela);
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.export.FlatAppearance.BorderSize = 0;
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.export.Location = new System.Drawing.Point(800, 498);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(119, 43);
            this.export.TabIndex = 1;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // convert
            // 
            this.convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.convert.FlatAppearance.BorderSize = 0;
            this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.convert.Location = new System.Drawing.Point(402, 507);
            this.convert.Margin = new System.Windows.Forms.Padding(4);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(43, 28);
            this.convert.TabIndex = 3;
            this.convert.Text = "➤";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // hex_lbl
            // 
            this.hex_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hex_lbl.AutoSize = true;
            this.hex_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hex_lbl.Location = new System.Drawing.Point(186, 512);
            this.hex_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hex_lbl.Name = "hex_lbl";
            this.hex_lbl.Size = new System.Drawing.Size(32, 17);
            this.hex_lbl.TabIndex = 4;
            this.hex_lbl.Text = "HEX";
            // 
            // hex_char
            // 
            this.hex_char.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hex_char.AutoSize = true;
            this.hex_char.BackColor = System.Drawing.SystemColors.Window;
            this.hex_char.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hex_char.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hex_char.Location = new System.Drawing.Point(230, 511);
            this.hex_char.Name = "hex_char";
            this.hex_char.Size = new System.Drawing.Size(17, 19);
            this.hex_char.TabIndex = 5;
            this.hex_char.Text = "#";
            // 
            // rgb_out_lbl
            // 
            this.rgb_out_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rgb_out_lbl.AutoSize = true;
            this.rgb_out_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgb_out_lbl.Location = new System.Drawing.Point(462, 510);
            this.rgb_out_lbl.Name = "rgb_out_lbl";
            this.rgb_out_lbl.Size = new System.Drawing.Size(131, 20);
            this.rgb_out_lbl.TabIndex = 6;
            this.rgb_out_lbl.Text = "R:        G:        B:    ";
            // 
            // chooseColor
            // 
            this.chooseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chooseColor.FlatAppearance.BorderSize = 0;
            this.chooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseColor.Location = new System.Drawing.Point(322, 508);
            this.chooseColor.Margin = new System.Windows.Forms.Padding(4);
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(61, 28);
            this.chooseColor.TabIndex = 7;
            this.chooseColor.Text = "Choose";
            this.chooseColor.UseVisualStyleBackColor = false;
            this.chooseColor.Click += new System.EventHandler(this.chooseColor_Click);
            // 
            // hex_color
            // 
            this.hex_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hex_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hex_color.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.hex_color.Location = new System.Drawing.Point(225, 509);
            this.hex_color.MaxLength = 6;
            this.hex_color.Name = "hex_color";
            this.hex_color.Size = new System.Drawing.Size(90, 23);
            this.hex_color.TabIndex = 8;
            this.hex_color.Text = "000000";
            this.hex_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hex_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIsEnter);
            this.hex_color.Leave += new System.EventHandler(this.CheckIsHEX);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Executable file (*.exe)|*.exe";
            this.saveFileDialog.Title = "Saving file";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(16, 503);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(93, 35);
            this.add.TabIndex = 9;
            this.add.Text = "Add row";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Location = new System.Drawing.Point(116, 512);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(38, 20);
            this.enter.TabIndex = 10;
            this.enter.Text = "\\n";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.data.DefaultCellStyle = dataGridViewCellStyle16;
            this.data.FillWeight = 98.47716F;
            this.data.HeaderText = "Text";
            this.data.Name = "data";
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // red
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.Format = "N0";
            this.red.DefaultCellStyle = dataGridViewCellStyle17;
            this.red.HeaderText = "R";
            this.red.MaxInputLength = 3;
            this.red.MinimumWidth = 50;
            this.red.Name = "red";
            this.red.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.red.Width = 50;
            // 
            // green
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Format = "N0";
            this.green.DefaultCellStyle = dataGridViewCellStyle18;
            this.green.HeaderText = "G";
            this.green.MaxInputLength = 3;
            this.green.MinimumWidth = 50;
            this.green.Name = "green";
            this.green.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.green.Width = 50;
            // 
            // blue
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.Format = "N0";
            this.blue.DefaultCellStyle = dataGridViewCellStyle19;
            this.blue.HeaderText = "B";
            this.blue.MaxInputLength = 3;
            this.blue.MinimumWidth = 50;
            this.blue.Name = "blue";
            this.blue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.blue.Width = 50;
            // 
            // textAlign
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textAlign.DefaultCellStyle = dataGridViewCellStyle20;
            this.textAlign.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.textAlign.HeaderText = "Text align";
            this.textAlign.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.textAlign.Name = "textAlign";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.add);
            this.Controls.Add(this.chooseColor);
            this.Controls.Add(this.rgb_out_lbl);
            this.Controls.Add(this.hex_char);
            this.Controls.Add(this.hex_lbl);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.export);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.hex_color);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Animated Wallpaper Creator";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label hex_lbl;
        private System.Windows.Forms.Label hex_char;
        private System.Windows.Forms.Label rgb_out_lbl;
        private System.Windows.Forms.Button chooseColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox hex_color;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.CheckBox enter;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn red;
        private System.Windows.Forms.DataGridViewTextBoxColumn green;
        private System.Windows.Forms.DataGridViewTextBoxColumn blue;
        private System.Windows.Forms.DataGridViewComboBoxColumn textAlign;
    }
}

