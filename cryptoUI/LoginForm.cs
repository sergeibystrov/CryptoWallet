using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
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
            labelLogCom.Hide();
            buttonOpenEyes.Hide();
        }
        public string textetex { get; set; }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (IfMatchLogin())
            {
                if (IfMatchPassword())
                {
                    Form1 form1 = new Form1();
                    textetex = this.textBoxLogin.Text;
                    form1.Show();
                    form1.UsernameText = this.textBoxLogin.Text;
                    this.Hide();
                }
                else
                {
                    labelLogCom.Show();
                    labelLogCom.Text = "Incorrect password!";
                    labelLogCom.BackColor = Color.Red;
                    textBoxPassword.BackColor = Color.Red;
                }
            }
            else
            {
                labelLogCom.Show();
                labelLogCom.Text = "Incorrect login!";
                labelLogCom.BackColor = Color.Red;
                textBoxLogin.BackColor = Color.Red;
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
            foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text && x.password == GetHash(textBoxPassword.Text)))
            {
                return true;
            }
            return false;
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenEyes_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            buttonOpenEyes.Hide();
            buttonEye.Show();
        }

        private void buttonEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            buttonEye.Hide();
            buttonOpenEyes.Show();
        }
    }

}
