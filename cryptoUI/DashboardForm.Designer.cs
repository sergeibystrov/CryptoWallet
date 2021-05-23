
namespace cryptoUI
{
    partial class DashboardForm
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
            FontAwesome.Sharp.IconButton buttonUpdate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.usdEarn = new System.Windows.Forms.TextBox();
            this.tokenToSell = new System.Windows.Forms.TextBox();
            this.tokenBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.usdPaid = new System.Windows.Forms.TextBox();
            this.tokenToBuy = new System.Windows.Forms.TextBox();
            this.usdBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPriceInUSD = new System.Windows.Forms.Label();
            this.textBoxPriceInUSD = new System.Windows.Forms.Label();
            this.DashboardCurrencyIcon = new System.Windows.Forms.PictureBox();
            this.panelChooseCrypto = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            buttonUpdate = new FontAwesome.Sharp.IconButton();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardCurrencyIcon)).BeginInit();
            this.panelChooseCrypto.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            buttonUpdate.IconChar = FontAwesome.Sharp.IconChar.Sync;
            buttonUpdate.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            buttonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonUpdate.IconSize = 35;
            buttonUpdate.Location = new System.Drawing.Point(283, 0);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(44, 41);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDashBoard.Controls.Add(this.button3);
            this.panelDashBoard.Controls.Add(this.usdEarn);
            this.panelDashBoard.Controls.Add(this.tokenToSell);
            this.panelDashBoard.Controls.Add(this.tokenBalance);
            this.panelDashBoard.Controls.Add(this.label6);
            this.panelDashBoard.Controls.Add(this.button2);
            this.panelDashBoard.Controls.Add(this.usdPaid);
            this.panelDashBoard.Controls.Add(this.tokenToBuy);
            this.panelDashBoard.Controls.Add(this.usdBalance);
            this.panelDashBoard.Controls.Add(this.label3);
            this.panelDashBoard.Controls.Add(this.labelPriceInUSD);
            this.panelDashBoard.Controls.Add(buttonUpdate);
            this.panelDashBoard.Controls.Add(this.textBoxPriceInUSD);
            this.panelDashBoard.Controls.Add(this.DashboardCurrencyIcon);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Margin = new System.Windows.Forms.Padding(2);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(331, 562);
            this.panelDashBoard.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 376);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "SELL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usdEarn
            // 
            this.usdEarn.Location = new System.Drawing.Point(64, 337);
            this.usdEarn.Margin = new System.Windows.Forms.Padding(2);
            this.usdEarn.Name = "usdEarn";
            this.usdEarn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usdEarn.Size = new System.Drawing.Size(160, 20);
            this.usdEarn.TabIndex = 25;
            this.usdEarn.TextChanged += new System.EventHandler(this.usdEarn_TextChanged);
            // 
            // tokenToSell
            // 
            this.tokenToSell.Location = new System.Drawing.Point(64, 303);
            this.tokenToSell.Margin = new System.Windows.Forms.Padding(2);
            this.tokenToSell.Name = "tokenToSell";
            this.tokenToSell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tokenToSell.Size = new System.Drawing.Size(160, 20);
            this.tokenToSell.TabIndex = 24;
            this.tokenToSell.TextChanged += new System.EventHandler(this.tokenToSell_TextChanged);
            // 
            // tokenBalance
            // 
            this.tokenBalance.AutoSize = true;
            this.tokenBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tokenBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tokenBalance.Location = new System.Drawing.Point(173, 359);
            this.tokenBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tokenBalance.Name = "tokenBalance";
            this.tokenBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tokenBalance.Size = new System.Drawing.Size(90, 15);
            this.tokenBalance.TabIndex = 23;
            this.tokenBalance.Text = "token balance: ";
            this.tokenBalance.Click += new System.EventHandler(this.tokenBalance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(26, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sell";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "BUY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usdPaid
            // 
            this.usdPaid.Location = new System.Drawing.Point(71, 204);
            this.usdPaid.Margin = new System.Windows.Forms.Padding(2);
            this.usdPaid.Name = "usdPaid";
            this.usdPaid.Size = new System.Drawing.Size(160, 20);
            this.usdPaid.TabIndex = 20;
            this.usdPaid.TextChanged += new System.EventHandler(this.usdPaid_TextChanged);
            // 
            // tokenToBuy
            // 
            this.tokenToBuy.Location = new System.Drawing.Point(71, 169);
            this.tokenToBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tokenToBuy.Name = "tokenToBuy";
            this.tokenToBuy.Size = new System.Drawing.Size(160, 20);
            this.tokenToBuy.TabIndex = 19;
            this.tokenToBuy.TextChanged += new System.EventHandler(this.tokenToBuy_TextChanged);
            // 
            // usdBalance
            // 
            this.usdBalance.AutoSize = true;
            this.usdBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usdBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usdBalance.Location = new System.Drawing.Point(180, 226);
            this.usdBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usdBalance.Name = "usdBalance";
            this.usdBalance.Size = new System.Drawing.Size(83, 15);
            this.usdBalance.TabIndex = 18;
            this.usdBalance.Text = "USD balance:";
            this.usdBalance.Click += new System.EventHandler(this.usdBalance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buy";
            // 
            // labelPriceInUSD
            // 
            this.labelPriceInUSD.AutoSize = true;
            this.labelPriceInUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceInUSD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriceInUSD.Location = new System.Drawing.Point(155, 124);
            this.labelPriceInUSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceInUSD.Name = "labelPriceInUSD";
            this.labelPriceInUSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPriceInUSD.Size = new System.Drawing.Size(76, 20);
            this.labelPriceInUSD.TabIndex = 3;
            this.labelPriceInUSD.Text = "60000.00";
            this.labelPriceInUSD.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxPriceInUSD
            // 
            this.textBoxPriceInUSD.AutoSize = true;
            this.textBoxPriceInUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceInUSD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPriceInUSD.Location = new System.Drawing.Point(75, 124);
            this.textBoxPriceInUSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxPriceInUSD.Name = "textBoxPriceInUSD";
            this.textBoxPriceInUSD.Size = new System.Drawing.Size(79, 20);
            this.textBoxPriceInUSD.TabIndex = 2;
            this.textBoxPriceInUSD.Text = "BTC/USD";
            // 
            // DashboardCurrencyIcon
            // 
            this.DashboardCurrencyIcon.Image = ((System.Drawing.Image)(resources.GetObject("DashboardCurrencyIcon.Image")));
            this.DashboardCurrencyIcon.Location = new System.Drawing.Point(101, 2);
            this.DashboardCurrencyIcon.Margin = new System.Windows.Forms.Padding(2);
            this.DashboardCurrencyIcon.Name = "DashboardCurrencyIcon";
            this.DashboardCurrencyIcon.Size = new System.Drawing.Size(100, 107);
            this.DashboardCurrencyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashboardCurrencyIcon.TabIndex = 0;
            this.DashboardCurrencyIcon.TabStop = false;
            // 
            // panelChooseCrypto
            // 
            this.panelChooseCrypto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelChooseCrypto.Controls.Add(this.button1);
            this.panelChooseCrypto.Controls.Add(this.textBox1);
            this.panelChooseCrypto.Controls.Add(this.label2);
            this.panelChooseCrypto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChooseCrypto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelChooseCrypto.Location = new System.Drawing.Point(331, 0);
            this.panelChooseCrypto.Margin = new System.Windows.Forms.Padding(2);
            this.panelChooseCrypto.Name = "panelChooseCrypto";
            this.panelChooseCrypto.Size = new System.Drawing.Size(400, 562);
            this.panelChooseCrypto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(32, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert cryptocurrency";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(731, 562);
            this.Controls.Add(this.panelChooseCrypto);
            this.Controls.Add(this.panelDashBoard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardCurrencyIcon)).EndInit();
            this.panelChooseCrypto.ResumeLayout(false);
            this.panelChooseCrypto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.PictureBox DashboardCurrencyIcon;
        private System.Windows.Forms.Label labelPriceInUSD;
        private System.Windows.Forms.Label textBoxPriceInUSD;
        private System.Windows.Forms.Panel panelChooseCrypto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox usdEarn;
        public System.Windows.Forms.TextBox tokenToSell;
        public System.Windows.Forms.Label tokenBalance;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usdPaid;
        private System.Windows.Forms.TextBox tokenToBuy;
        private System.Windows.Forms.Label usdBalance;
        private System.Windows.Forms.Label label3;
    }
}