﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public bool BoldChecked { get; set; }
        public bool UnderlineChecked { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] ffArray = FontFamily.Families;
           
            int[] sizes = new int[] { 8,9,10,11,12,14,16,18,20,22,24,26,28,36,48,72 };
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
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

            richTextBox.SelectionColor = Color.FromName(cbx_Color.SelectedItem.ToString());
           //Update in night
        }

        private void cbx_Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_TextSize.SelectedIndex = 0;
            richTextBox.SelectionFont = new Font(cbx_Fonts.Text, int.Parse(cbx_TextSize.Text));
        }
        private void AllignText(object sender, EventArgs e)
        {
            if (sender is Guna.UI.WinForms.GunaAdvenceButton  btn)
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
        }

        private void cbx_Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {
            if (BoldChecked)
            {
                BoldChecked = false;
                btn_Bold.BaseColor = Color.Transparent;
            }
            else
            {
                BoldChecked = true;
                btn_Bold.BaseColor = Color.FromArgb(135, 206, 250);
            }
           
            Font boldUnderFont = new Font(richTextBox.SelectionFont, FontStyle.Bold);
            richTextBox.SelectionFont = boldUnderFont;
        }

        private void btn_Underline_Click(object sender, EventArgs e)
        {
            if (UnderlineChecked)
            {
                
                UnderlineChecked = false;
                btn_Underline.BaseColor = Color.Transparent;
            }
            else
            {
                Font boldUnderFont = new Font(richTextBox.SelectionFont, FontStyle.Underline);
                richTextBox.SelectionFont = boldUnderFont;
                UnderlineChecked = true;
                btn_Underline.BaseColor = Color.FromArgb(135, 206, 250);
            }
          
        }
    }
}
