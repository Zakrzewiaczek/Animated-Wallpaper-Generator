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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.add = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.CheckBox();
            this.bg_color_char = new System.Windows.Forms.Label();
            this.bg_color_lbl = new System.Windows.Forms.Label();
            this.bg_color = new System.Windows.Forms.TextBox();
            this.chooseColor = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.color});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle4;
            this.tabela.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tabela.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tabela.Location = new System.Drawing.Point(14, 15);
            this.tabela.Margin = new System.Windows.Forms.Padding(4);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(821, 426);
            this.tabela.TabIndex = 0;
            this.tabela.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.isHex_tabela);
            this.tabela.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_RemoveHash);
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.export.FlatAppearance.BorderSize = 0;
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.export.Location = new System.Drawing.Point(716, 450);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(119, 43);
            this.export.TabIndex = 1;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
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
            this.add.Location = new System.Drawing.Point(16, 455);
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
            this.enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enter.AutoSize = true;
            this.enter.Location = new System.Drawing.Point(116, 462);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(38, 20);
            this.enter.TabIndex = 10;
            this.enter.Text = "\\n";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // bg_color_char
            // 
            this.bg_color_char.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color_char.AutoSize = true;
            this.bg_color_char.BackColor = System.Drawing.SystemColors.Window;
            this.bg_color_char.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bg_color_char.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bg_color_char.Location = new System.Drawing.Point(605, 465);
            this.bg_color_char.Name = "bg_color_char";
            this.bg_color_char.Size = new System.Drawing.Size(17, 19);
            this.bg_color_char.TabIndex = 12;
            this.bg_color_char.Text = "#";
            // 
            // bg_color_lbl
            // 
            this.bg_color_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color_lbl.AutoSize = true;
            this.bg_color_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bg_color_lbl.Location = new System.Drawing.Point(504, 466);
            this.bg_color_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bg_color_lbl.Name = "bg_color_lbl";
            this.bg_color_lbl.Size = new System.Drawing.Size(94, 17);
            this.bg_color_lbl.TabIndex = 11;
            this.bg_color_lbl.Text = "Bg color (HEX)";
            // 
            // bg_color
            // 
            this.bg_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bg_color.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bg_color.Location = new System.Drawing.Point(602, 463);
            this.bg_color.MaxLength = 6;
            this.bg_color.Name = "bg_color";
            this.bg_color.Size = new System.Drawing.Size(98, 23);
            this.bg_color.TabIndex = 13;
            this.bg_color.Text = "000000";
            this.bg_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bg_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bg_color_KeyPress);
            this.bg_color.Leave += new System.EventHandler(this.isHEX_bg);
            // 
            // chooseColor
            // 
            this.chooseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chooseColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chooseColor.FlatAppearance.BorderSize = 0;
            this.chooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseColor.Location = new System.Drawing.Point(185, 459);
            this.chooseColor.Margin = new System.Windows.Forms.Padding(4);
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(96, 28);
            this.chooseColor.TabIndex = 14;
            this.chooseColor.Text = "Choose color";
            this.chooseColor.UseVisualStyleBackColor = false;
            this.chooseColor.Click += new System.EventHandler(this.chooseColor_Click);
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.FillWeight = 98.47716F;
            this.data.HeaderText = "Text";
            this.data.MaxInputLength = 115;
            this.data.Name = "data";
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // color
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "000000";
            this.color.DefaultCellStyle = dataGridViewCellStyle3;
            this.color.HeaderText = "Color (HEX)";
            this.color.MaxInputLength = 6;
            this.color.MinimumWidth = 100;
            this.color.Name = "color";
            this.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(849, 506);
            this.Controls.Add(this.chooseColor);
            this.Controls.Add(this.bg_color_char);
            this.Controls.Add(this.bg_color_lbl);
            this.Controls.Add(this.bg_color);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.add);
            this.Controls.Add(this.export);
            this.Controls.Add(this.tabela);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(671, 425);
            this.Name = "Form1";
            this.Text = "Animated Wallpaper Creator";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.CheckBox enter;
        private System.Windows.Forms.Label bg_color_char;
        private System.Windows.Forms.Label bg_color_lbl;
        private System.Windows.Forms.TextBox bg_color;
        private System.Windows.Forms.Button chooseColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
    }
}

