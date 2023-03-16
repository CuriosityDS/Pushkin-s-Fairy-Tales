using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pushkin__s_Fairy_Tales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            pictureBox1.Image = System.Drawing.Image.FromFile(@"bun\\bun.jpg");
            richTextBox1.LoadFile(System.Windows.Forms.Application.StartupPath + @"\\bun\\bun.rtf");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"bun\\bun.jpg");
                richTextBox1.LoadFile(System.Windows.Forms.Application.StartupPath + @"\\bun\\bun.rtf");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"Chicken ryaba\\Chicken ryaba.jpg");
                richTextBox1.LoadFile(System.Windows.Forms.Application.StartupPath + @"\\Chicken ryaba\\Chicken ryaba.rtf");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"Masha and the Bear\\Masha and the Bear.jpg");
                richTextBox1.LoadFile(System.Windows.Forms.Application.StartupPath + @"\\Masha and the Bear\\Masha and the Bear.rtf");
            }
        }
    }
}
