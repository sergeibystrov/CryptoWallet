using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;



namespace cryptoUI
{
    public partial class HomeForm : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;

        public HomeForm()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);
            //Form
            this.Text = string.Empty;
        }
        public string UsernameText
        {
            get
            {
                return this.Username.Text;
            }
            set
            {
                this.Username.Text = value;
            }
        }
        //Structures

        private struct RGDBCollors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 255);
        }

        //Methods

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleChildForm.Text = childForm.Text;

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                //Icon current Child Form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = currentButton.IconColor;

            }
        }
        private void DisableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGDBCollors.color1);
            OpenChildForm(new DashboardForm() { UsernameText = Username.Text });
        }

        private void walletButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGDBCollors.color2);
            OpenChildForm(new WalletForm() { UsernameText = Username.Text });
        }

        private void tradingButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGDBCollors.color3);
            OpenChildForm(new TradingForm() { UsernameText = Username.Text });
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGDBCollors.color4);
            OpenChildForm(new ChartsForm() { UsernameText = Username.Text });
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (titleChildForm.Text != "Home")
            {
                currentChildForm.Close();
            }   
            Reset();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 194, 0);
            titleChildForm.Text = "Home";

        }

        // Allows to drag form holding top panel bar
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
