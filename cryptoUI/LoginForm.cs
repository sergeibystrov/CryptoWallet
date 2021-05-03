using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptoUI
{
    public partial class LoginForm : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            if (IfMatchLogin())
            {
                if (IfMatchPassword())
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    form1.UsernameText = this.textBoxLogin.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect login!");
            }
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            Form Registration = new Registration();
            Registration.Show();
            this.Hide();
        }

        private bool IfMatchLogin()
        {
            foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text))
            {
                return true;
            }
            return false;
        }
        private bool IfMatchPassword()
        {
            foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text && x.password == textBoxPassword.Text))
            {
                return true;
            }
            return false;
        }

    }
}
