using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool BoldChecked = false;
        public bool UnderlineChecked = false;
        public bool ItalicChecked = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] ffArray = FontFamily.Families;

            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var font in ffArray)
            {
                cbx_Fonts.Items.Add(font.Name);
            }
            foreach (var size in sizes)
            {
                cbx_TextSize.Items.Add(size);
            }
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    cbx_Color.Items.Add(prop.Name);

            }
            cbx_Color.SelectedIndex = 8;
            cbx_Fonts.SelectedIndex = 0;
            cbx_TextSize.SelectedIndex = 0;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

            richTextBox.SelectionColor = Color.FromName(cbx_Color.SelectedItem.ToString());
        }

        private void cbx_Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_TextSize.SelectedIndex = 0;
            richTextBox.SelectionFont = new Font(cbx_Fonts.Text, int.Parse(cbx_TextSize.Text));
            FontConfiguration();
        }
        private void AllignText(object sender, EventArgs e)
        {
            if (sender is Guna.UI.WinForms.GunaAdvenceButton btn)
            {
                switch (btn.Text)
                {
                    case "L":
                        richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                        break;
                    case "C":
                        richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                        break;
                    case "R":
                        richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                        break;
                }
            }
        }
        private void cbx_TextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(cbx_Fonts.Text, int.Parse(cbx_TextSize.Text));
            FontConfiguration();
        }

        private void cbx_Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ButtonConfiguration(ref bool check, ref Guna.UI.WinForms.GunaAdvenceButton fontButton)
        {
            if (check)
            {
                check = false;
                fontButton.BaseColor = Color.Transparent;
            }
            else
            {
                check = true;
                fontButton.BaseColor = Color.FromArgb(135, 206, 250);
            }
        }
        private void FontConfiguration()
        {
            if (BoldChecked && ItalicChecked && UnderlineChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if (BoldChecked && ItalicChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic);
            }
            else if (BoldChecked && UnderlineChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            }
            else if (UnderlineChecked && ItalicChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | FontStyle.Underline);
            }
            else if (BoldChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold);
            }
            else if (ItalicChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic);
            }
            else if (UnderlineChecked)
            {
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline);
            }
            else
            {
                richTextBox.SelectionFont = new Font(cbx_Fonts.Text, int.Parse(cbx_TextSize.Text));
                // MessageBox.Show(richTextBox.SelectionFont.ToString());
            }
        }
        private void btn_Bold_Click(object sender, EventArgs e)
        {
            ButtonConfiguration(ref BoldChecked, ref btn_Bold);
            FontConfiguration();
        }
        private void btn_Underline_Click(object sender, EventArgs e)
        {
            ButtonConfiguration(ref UnderlineChecked, ref btn_Underline);
            FontConfiguration();
        }

        private void btn_Italic_Click(object sender, EventArgs e)
        {
            ButtonConfiguration(ref ItalicChecked, ref btn_Italic);
            FontConfiguration();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(openFileDialog1.FileName))
                {
                    sw.Write(richTextBox.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text files|*.txt";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    richTextBox.Text = sr.ReadToEnd();
                }

            }

        }
    }
}
