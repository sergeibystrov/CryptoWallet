
namespace cryptoUI
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.chartButton = new FontAwesome.Sharp.IconButton();
            this.tradingButton = new FontAwesome.Sharp.IconButton();
            this.walletButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.titleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.chartButton);
            this.panelMenu.Controls.Add(this.tradingButton);
            this.panelMenu.Controls.Add(this.walletButton);
            this.panelMenu.Controls.Add(this.dashboardButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 682);
            this.panelMenu.TabIndex = 0;
            // 
            // chartButton
            // 
            this.chartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartButton.FlatAppearance.BorderSize = 0;
            this.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartButton.ForeColor = System.Drawing.Color.White;
            this.chartButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.chartButton.IconColor = System.Drawing.Color.White;
            this.chartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chartButton.IconSize = 32;
            this.chartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartButton.Location = new System.Drawing.Point(0, 261);
            this.chartButton.Margin = new System.Windows.Forms.Padding(2);
            this.chartButton.Name = "chartButton";
            this.chartButton.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.chartButton.Size = new System.Drawing.Size(165, 49);
            this.chartButton.TabIndex = 4;
            this.chartButton.Text = "Charts";
            this.chartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // tradingButton
            // 
            this.tradingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tradingButton.FlatAppearance.BorderSize = 0;
            this.tradingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tradingButton.ForeColor = System.Drawing.Color.White;
            this.tradingButton.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.tradingButton.IconColor = System.Drawing.Color.White;
            this.tradingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tradingButton.IconSize = 32;
            this.tradingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tradingButton.Location = new System.Drawing.Point(0, 212);
            this.tradingButton.Margin = new System.Windows.Forms.Padding(2);
            this.tradingButton.Name = "tradingButton";
            this.tradingButton.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.tradingButton.Size = new System.Drawing.Size(165, 49);
            this.tradingButton.TabIndex = 3;
            this.tradingButton.Text = "Trading";
            this.tradingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tradingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tradingButton.UseVisualStyleBackColor = true;
            this.tradingButton.Click += new System.EventHandler(this.tradingButton_Click);
            // 
            // walletButton
            // 
            this.walletButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.walletButton.FlatAppearance.BorderSize = 0;
            this.walletButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletButton.ForeColor = System.Drawing.Color.White;
            this.walletButton.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.walletButton.IconColor = System.Drawing.Color.White;
            this.walletButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.walletButton.IconSize = 32;
            this.walletButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletButton.Location = new System.Drawing.Point(0, 163);
            this.walletButton.Margin = new System.Windows.Forms.Padding(2);
            this.walletButton.Name = "walletButton";
            this.walletButton.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.walletButton.Size = new System.Drawing.Size(165, 49);
            this.walletButton.TabIndex = 2;
            this.walletButton.Text = "Wallet";
            this.walletButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.walletButton.UseVisualStyleBackColor = true;
            this.walletButton.Click += new System.EventHandler(this.walletButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.dashboardButton.IconColor = System.Drawing.Color.White;
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 32;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 114);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.dashboardButton.Size = new System.Drawing.Size(165, 49);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.panelLogo.Size = new System.Drawing.Size(165, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::cryptoUI.Properties.Resources.pngegg;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(165, 114);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(519, 274);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.titleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 65);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Myanmar Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gold;
            this.Username.Location = new System.Drawing.Point(938, 17);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(114, 37);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // titleChildForm
            // 
            this.titleChildForm.AutoSize = true;
            this.titleChildForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.titleChildForm.Location = new System.Drawing.Point(47, 24);
            this.titleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleChildForm.Name = "titleChildForm";
            this.titleChildForm.Size = new System.Drawing.Size(54, 18);
            this.titleChildForm.TabIndex = 1;
            this.titleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 37;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(4, 17);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(38, 37);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.childFormPanel.Controls.Add(this.richTextBox1);
            this.childFormPanel.Controls.Add(this.label4);
            this.childFormPanel.Controls.Add(this.label3);
            this.childFormPanel.Controls.Add(this.label2);
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Controls.Add(this.pictureBox4);
            this.childFormPanel.Controls.Add(this.pictureBox3);
            this.childFormPanel.Controls.Add(this.pictureBox2);
            this.childFormPanel.Controls.Add(this.pictureBox1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(165, 65);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1152, 617);
            this.childFormPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "In Dashboard, you can monitor the value of the cryptocurrency\nand buy or sell cry" +
    "ptocurrency.";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 196);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 49);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 49);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 49);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(62, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "In Wallet, you can find out what cryptocurrency you own and add funds your balanc" +
    "e.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(62, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "In Trading, you can see the history of the transaction and see your revenue.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(62, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "In Charts, you can see a chart of the price of a cryptocurrency and a chart of th" +
    "e revenue.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gold;
            this.richTextBox1.Location = new System.Drawing.Point(514, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(626, 196);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 682);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton chartButton;
        private FontAwesome.Sharp.IconButton tradingButton;
        private FontAwesome.Sharp.IconButton walletButton;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

