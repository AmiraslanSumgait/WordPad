using System;
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
    }
}
