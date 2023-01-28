using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignIn_SignUp.BL;
using SignIn_SignUp.DL;

namespace SignIn_SignUp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string role = textBox3.Text;
            MUserBL user = new MUserBL(userName, password, role);
            MUserDL.Users.Add(user);
            MUserDL.writeData();
            MessageBox.Show("Account Created");
            this.Hide();
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
