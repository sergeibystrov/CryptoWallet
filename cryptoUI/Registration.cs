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
    public partial class Registration : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.TextLength < 4)
            {
                MessageBox.Show("Login too short!");
                return;
            }
            else
            {
                foreach (var x in bazadanych.Users.Where(x => x.username == textBoxLogin.Text))
                {
                    MessageBox.Show("Login is already taken!");
                    return;
                }
            }
            if (textBoxPassword.TextLength < 4)
            {
                MessageBox.Show("Password too short!");
                return;
            }
            else if (textBoxRepeatPassword.Text != textBoxPassword.Text)
            {
                MessageBox.Show("Your password and repeat password do not match");
                return;
            }
            User newUser = new User();
            newUser.username = textBoxLogin.Text.ToString();
            newUser.password = textBoxPassword.Text.ToString();
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
    }
}
