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
    public partial class Registration : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        public Registration()
        {
            InitializeComponent();
            labelReg.Hide();
            buttonOpenEyes1.Hide();
            buttonOpenEyes2.Hide();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.TextLength < 4)
            {
                labelReg.Show();
                textBoxLogin.BackColor = Color.Red;
                labelReg.Text = "Login too short!"; 
                return;
            }
            else
            {
                foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text))
                {
                    labelReg.Show();
                    textBoxLogin.BackColor = Color.Red;
                    labelReg.Text = "Login is already taken!";
                    return;
                }
            }
            textBoxLogin.BackColor = Color.DarkSlateBlue;
            if (textBoxPassword.TextLength < 4)
            {
                labelReg.Show();
                textBoxPassword.BackColor = Color.Red;
                labelReg.Text = "Password too short!";
                return;
            }
            else if (textBoxRepeatPassword.Text != textBoxPassword.Text)
            {
                textBoxPassword.BackColor = Color.DarkSlateBlue;
                labelReg.Show();
                textBoxPassword.BackColor = Color.Red;
                textBoxRepeatPassword.BackColor = Color.Red;
                labelReg.Text = "Passwords do not match!";
                return;
            }
            User newUser = new User();
            newUser.username = textBoxLogin.Text.ToString();
            newUser.password = GetHash(textBoxPassword.Text).ToString();
            newUser.balance = 300;
            bazadanych.Users.InsertOnSubmit(newUser);
            bazadanych.SubmitChanges();
            MessageBox.Show("Account created");
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void buttonOpenEyes2_Click(object sender, EventArgs e)
        {
            textBoxRepeatPassword.UseSystemPasswordChar = !textBoxRepeatPassword.UseSystemPasswordChar;
            buttonOpenEyes2.Hide();
            buttonEye2.Show();
        }

        private void buttonOpenEyes1_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            buttonOpenEyes1.Hide();
            buttonEye1.Show();
        }

        private void buttonEye1_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            buttonEye1.Hide();
            buttonOpenEyes1.Show();
        }

        private void buttonEye2_Click(object sender, EventArgs e)
        {
            textBoxRepeatPassword.UseSystemPasswordChar = !textBoxRepeatPassword.UseSystemPasswordChar;
            buttonEye2.Hide();
            buttonOpenEyes2.Show();
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBoxLogin.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBoxRepeatPassword.Focus();
            }
        }

        private void textBoxRepeatPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBoxPassword.Focus();
            }
        }
    }
}
