using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to remind your username and password");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpassword.Text;

            if(username == "abc" && password == "123")
            {
                MessageBox.Show("Login success...!", "Login status !");
                this.Hide();
                Home obj = new Home();
                obj.Show();
            }else if(username == "" || password == "")
            {
                MessageBox.Show("All fields are required...!, Try again", "Login Status");
            }else
            {
                MessageBox.Show("Login not success...!, Try again", "Login status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Text = "";
                txtpassword.Text = "";
            }
        }
    }
}
