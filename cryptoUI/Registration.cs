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
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.TextLength < 4)
            {
                labelReg.Show();
                textBoxLogin.BackColor = Color.Red;
                labelReg.Text = "Login too short!";
                labelReg.BackColor = Color.Red; 
                return;
            }
            else
            {
                foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text))
                {
                    labelReg.Show();
                    textBoxLogin.BackColor = Color.Red;
                    labelReg.Text = "Login is already taken!";
                    labelReg.BackColor = Color.Red;
                    return;
                }
            }
            if (textBoxPassword.TextLength < 4)
            {
                labelReg.Show();
                textBoxPassword.BackColor = Color.Red;
                labelReg.Text = "Password too short!";
                labelReg.BackColor = Color.Red;
                return;
            }
            else if (textBoxRepeatPassword.Text != textBoxPassword.Text)
            {
                labelReg.Show();
                textBoxPassword.BackColor = Color.Red;
                textBoxRepeatPassword.BackColor = Color.Red;
                labelReg.Text = "Passwords do not match!";
                labelReg.BackColor = Color.Red;
                return;
            }
            User newUser = new User();
            newUser.username = textBoxLogin.Text.ToString();
            newUser.password = GetHash(textBoxPassword.Text).ToString();
            bazadanych.Users.InsertOnSubmit(newUser);
            bazadanych.SubmitChanges();
            MessageBox.Show("Account created");
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void buttonEye1_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void buttonEye2_Click(object sender, EventArgs e)
        {
            textBoxRepeatPassword.UseSystemPasswordChar = !textBoxRepeatPassword.UseSystemPasswordChar;
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
    }
}
