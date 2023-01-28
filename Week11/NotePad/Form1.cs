using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textbox1.Font.Bold == false)
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Bold);
            }
            else
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Regular);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textbox1.Font.Italic == false)
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Italic);
            }
            else
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Regular);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textbox1.Font.Underline == false)
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Underline);
            }
            else
            {
                textbox1.Font = new Font(textbox1.Font, FontStyle.Regular);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = comboBox1.SelectedItem.ToString();
            int Fsize = int.Parse(comboBox2.SelectedItem.ToString());
            textbox1.Font = new System.Drawing.Font(font, Fsize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = comboBox1.SelectedItem.ToString();
            int Fsize = int.Parse(comboBox2.SelectedItem.ToString());
            textbox1.Font = new System.Drawing.Font(font, Fsize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
