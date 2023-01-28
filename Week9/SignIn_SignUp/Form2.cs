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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            MUserBL user = new MUserBL(userName, password);
            string role = MUserDL.checkData(user);
            if (role == "Admin")
            {
                MessageBox.Show("Welcome Admin");
            }
            else if (role == "Customer")
            {
                MessageBox.Show("Welcome Customer");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
