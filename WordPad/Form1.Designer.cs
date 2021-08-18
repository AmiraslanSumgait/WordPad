
namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cbx_TextSize = new System.Windows.Forms.ComboBox();
            this.cbx_Fonts = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbx_Color = new Guna.UI.WinForms.GunaComboBox();
            this.btn_RightAlign = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_CenterAlign = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_LeftAlign = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Bold = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Underline = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Italic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 77);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(58, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Font";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(242, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(52, 30);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Size";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(388, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(112, 30);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "FontStyle";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(569, 75);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 30);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Alignment";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 162);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1033, 567);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // cbx_TextSize
            // 
            this.cbx_TextSize.FormattingEnabled = true;
            this.cbx_TextSize.Location = new System.Drawing.Point(236, 110);
            this.cbx_TextSize.Name = "cbx_TextSize";
            this.cbx_TextSize.Size = new System.Drawing.Size(69, 21);
            this.cbx_TextSize.TabIndex = 5;
            this.cbx_TextSize.SelectedIndexChanged += new System.EventHandler(this.cbx_TextSize_SelectedIndexChanged);
            // 
            // cbx_Fonts
            // 
            this.cbx_Fonts.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Fonts.BaseColor = System.Drawing.Color.White;
            this.cbx_Fonts.BorderColor = System.Drawing.Color.Silver;
            this.cbx_Fonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Fonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Fonts.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Fonts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Fonts.ForeColor = System.Drawing.Color.Black;
            this.cbx_Fonts.FormattingEnabled = true;
            this.cbx_Fonts.Location = new System.Drawing.Point(28, 110);
            this.cbx_Fonts.Name = "cbx_Fonts";
            this.cbx_Fonts.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_Fonts.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Fonts.Size = new System.Drawing.Size(171, 26);
            this.cbx_Fonts.TabIndex = 6;
            this.cbx_Fonts.SelectedIndexChanged += new System.EventHandler(this.cbx_Fonts_SelectedIndexChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(731, 75);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(66, 30);
            this.gunaLabel5.TabIndex = 13;
            this.gunaLabel5.Text = "Color";
            // 
            // cbx_Color
            // 
            this.cbx_Color.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Color.BaseColor = System.Drawing.Color.White;
            this.cbx_Color.BorderColor = System.Drawing.Color.Silver;
            this.cbx_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Color.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Color.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Color.ForeColor = System.Drawing.Color.Black;
            this.cbx_Color.FormattingEnabled = true;
            this.cbx_Color.Location = new System.Drawing.Point(726, 110);
            this.cbx_Color.Name = "cbx_Color";
            this.cbx_Color.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_Color.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Color.Size = new System.Drawing.Size(94, 26);
            this.cbx_Color.TabIndex = 14;
            // 
            // btn_RightAlign
            // 
            this.btn_RightAlign.AnimationHoverSpeed = 0.07F;
            this.btn_RightAlign.AnimationSpeed = 0.03F;
            this.btn_RightAlign.BaseColor = System.Drawing.Color.White;
            this.btn_RightAlign.BorderColor = System.Drawing.Color.Black;
            this.btn_RightAlign.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_RightAlign.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_RightAlign.CheckedForeColor = System.Drawing.Color.White;
            this.btn_RightAlign.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_RightAlign.CheckedImage")));
            this.btn_RightAlign.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_RightAlign.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_RightAlign.FocusedColor = System.Drawing.Color.Empty;
            this.btn_RightAlign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RightAlign.ForeColor = System.Drawing.Color.Black;
            this.btn_RightAlign.Image = null;
            this.btn_RightAlign.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_RightAlign.LineColor = System.Drawing.Color.White;
            this.btn_RightAlign.Location = new System.Drawing.Point(660, 110);
            this.btn_RightAlign.Name = "btn_RightAlign";
            this.btn_RightAlign.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_RightAlign.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_RightAlign.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_RightAlign.OnHoverImage = null;
            this.btn_RightAlign.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_RightAlign.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_RightAlign.Size = new System.Drawing.Size(37, 28);
            this.btn_RightAlign.TabIndex = 12;
            this.btn_RightAlign.Text = "R";
            this.btn_RightAlign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_RightAlign.Click += new System.EventHandler(this.AllignText);
            // 
            // btn_CenterAlign
            // 
            this.btn_CenterAlign.AnimationHoverSpeed = 0.07F;
            this.btn_CenterAlign.AnimationSpeed = 0.03F;
            this.btn_CenterAlign.BaseColor = System.Drawing.Color.White;
            this.btn_CenterAlign.BorderColor = System.Drawing.Color.Black;
            this.btn_CenterAlign.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_CenterAlign.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_CenterAlign.CheckedForeColor = System.Drawing.Color.White;
            this.btn_CenterAlign.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_CenterAlign.CheckedImage")));
            this.btn_CenterAlign.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_CenterAlign.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CenterAlign.FocusedColor = System.Drawing.Color.Empty;
            this.btn_CenterAlign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CenterAlign.ForeColor = System.Drawing.Color.Black;
            this.btn_CenterAlign.Image = null;
            this.btn_CenterAlign.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_CenterAlign.LineColor = System.Drawing.Color.White;
            this.btn_CenterAlign.Location = new System.Drawing.Point(617, 110);
            this.btn_CenterAlign.Name = "btn_CenterAlign";
            this.btn_CenterAlign.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CenterAlign.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_CenterAlign.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_CenterAlign.OnHoverImage = null;
            this.btn_CenterAlign.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_CenterAlign.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_CenterAlign.Size = new System.Drawing.Size(37, 28);
            this.btn_CenterAlign.TabIndex = 11;
            this.btn_CenterAlign.Text = "C";
            this.btn_CenterAlign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CenterAlign.Click += new System.EventHandler(this.AllignText);
            // 
            // btn_LeftAlign
            // 
            this.btn_LeftAlign.AnimationHoverSpeed = 0.07F;
            this.btn_LeftAlign.AnimationSpeed = 0.03F;
            this.btn_LeftAlign.BaseColor = System.Drawing.Color.White;
            this.btn_LeftAlign.BorderColor = System.Drawing.Color.Black;
            this.btn_LeftAlign.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_LeftAlign.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_LeftAlign.CheckedForeColor = System.Drawing.Color.White;
            this.btn_LeftAlign.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_LeftAlign.CheckedImage")));
            this.btn_LeftAlign.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_LeftAlign.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_LeftAlign.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LeftAlign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeftAlign.ForeColor = System.Drawing.Color.Black;
            this.btn_LeftAlign.Image = null;
            this.btn_LeftAlign.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LeftAlign.LineColor = System.Drawing.Color.White;
            this.btn_LeftAlign.Location = new System.Drawing.Point(574, 110);
            this.btn_LeftAlign.Name = "btn_LeftAlign";
            this.btn_LeftAlign.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_LeftAlign.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_LeftAlign.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LeftAlign.OnHoverImage = null;
            this.btn_LeftAlign.OnHoverLineColor = System.Drawing.Color.White;
            this.btn_LeftAlign.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_LeftAlign.Size = new System.Drawing.Size(37, 28);
            this.btn_LeftAlign.TabIndex = 10;
            this.btn_LeftAlign.Text = "L";
            this.btn_LeftAlign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_LeftAlign.Click += new System.EventHandler(this.AllignText);
            // 
            // btn_Bold
            // 
            this.btn_Bold.AnimationHoverSpeed = 0.07F;
            this.btn_Bold.AnimationSpeed = 0.03F;
            this.btn_Bold.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_Bold.BorderColor = System.Drawing.Color.Black;
            this.btn_Bold.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Bold.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Bold.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Bold.CheckedImage = global::WordPad.Properties.Resources.Black_Bold;
            this.btn_Bold.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Bold.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Bold.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Bold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Bold.ForeColor = System.Drawing.Color.White;
            this.btn_Bold.Image = global::WordPad.Properties.Resources.Black_Bold;
            this.btn_Bold.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Bold.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Bold.Location = new System.Drawing.Point(381, 108);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_Bold.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Bold.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Bold.OnHoverImage = null;
            this.btn_Bold.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Bold.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Bold.Size = new System.Drawing.Size(43, 39);
            this.btn_Bold.TabIndex = 18;
            this.btn_Bold.Click += new System.EventHandler(this.btn_Bold_Click);
            // 
            // btn_Underline
            // 
            this.btn_Underline.AnimationHoverSpeed = 0.07F;
            this.btn_Underline.AnimationSpeed = 0.03F;
            this.btn_Underline.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_Underline.BorderColor = System.Drawing.Color.Black;
            this.btn_Underline.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Underline.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Underline.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Underline.CheckedImage = global::WordPad.Properties.Resources.Black_Undirline;
            this.btn_Underline.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Underline.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Underline.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Underline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Underline.ForeColor = System.Drawing.Color.White;
            this.btn_Underline.Image = global::WordPad.Properties.Resources.Black_Undirline;
            this.btn_Underline.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Underline.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Underline.Location = new System.Drawing.Point(420, 108);
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_Underline.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Underline.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Underline.OnHoverImage = null;
            this.btn_Underline.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Underline.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Underline.Size = new System.Drawing.Size(43, 39);
            this.btn_Underline.TabIndex = 19;
            this.btn_Underline.Click += new System.EventHandler(this.btn_Underline_Click);
            // 
            // btn_Italic
            // 
            this.btn_Italic.AnimationHoverSpeed = 0.07F;
            this.btn_Italic.AnimationSpeed = 0.03F;
            this.btn_Italic.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_Italic.BorderColor = System.Drawing.Color.Black;
            this.btn_Italic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Italic.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Italic.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Italic.CheckedImage = global::WordPad.Properties.Resources.Black_Italic;
            this.btn_Italic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Italic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Italic.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Italic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Italic.ForeColor = System.Drawing.Color.White;
            this.btn_Italic.Image = global::WordPad.Properties.Resources.Black_Italic;
            this.btn_Italic.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Italic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Italic.Location = new System.Drawing.Point(457, 108);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_Italic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Italic.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Italic.OnHoverImage = null;
            this.btn_Italic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Italic.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Italic.Size = new System.Drawing.Size(43, 39);
            this.btn_Italic.TabIndex = 20;
            this.btn_Italic.Click += new System.EventHandler(this.btn_Italic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 741);
            this.Controls.Add(this.btn_Italic);
            this.Controls.Add(this.btn_Underline);
            this.Controls.Add(this.btn_Bold);
            this.Controls.Add(this.cbx_Color);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btn_RightAlign);
            this.Controls.Add(this.btn_CenterAlign);
            this.Controls.Add(this.btn_LeftAlign);
            this.Controls.Add(this.cbx_Fonts);
            this.Controls.Add(this.cbx_TextSize);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox cbx_TextSize;
        private Guna.UI.WinForms.GunaComboBox cbx_Fonts;
        private Guna.UI.WinForms.GunaAdvenceButton btn_LeftAlign;
        private Guna.UI.WinForms.GunaAdvenceButton btn_CenterAlign;
        private Guna.UI.WinForms.GunaAdvenceButton btn_RightAlign;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cbx_Color;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Bold;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Underline;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Italic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

