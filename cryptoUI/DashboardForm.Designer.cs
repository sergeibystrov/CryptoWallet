
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
            this.VolumeAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LowestPrice = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.HighestPrice = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelNameOfCurrency = new System.Windows.Forms.Label();
            this.labelDollar = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.DashboardCurrencyPair = new System.Windows.Forms.Label();
            this.DashboardCurrencyIcon = new System.Windows.Forms.PictureBox();
            this.panelChooseCrypto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonUpdate = new FontAwesome.Sharp.IconButton();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardCurrencyIcon)).BeginInit();
            this.panelChooseCrypto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            buttonUpdate.IconChar = FontAwesome.Sharp.IconChar.Sync;
            buttonUpdate.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            buttonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonUpdate.IconSize = 35;
            buttonUpdate.Location = new System.Drawing.Point(248, 0);
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
            this.panelDashBoard.Controls.Add(buttonUpdate);
            this.panelDashBoard.Controls.Add(this.VolumeAmount);
            this.panelDashBoard.Controls.Add(this.label1);
            this.panelDashBoard.Controls.Add(this.LowestPrice);
            this.panelDashBoard.Controls.Add(this.labelLow);
            this.panelDashBoard.Controls.Add(this.HighestPrice);
            this.panelDashBoard.Controls.Add(this.labelHigh);
            this.panelDashBoard.Controls.Add(this.labelNameOfCurrency);
            this.panelDashBoard.Controls.Add(this.labelDollar);
            this.panelDashBoard.Controls.Add(this.labelCurrentPrice);
            this.panelDashBoard.Controls.Add(this.DashboardCurrencyPair);
            this.panelDashBoard.Controls.Add(this.DashboardCurrencyIcon);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Margin = new System.Windows.Forms.Padding(2);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(292, 422);
            this.panelDashBoard.TabIndex = 0;
            // 
            // VolumeAmount
            // 
            this.VolumeAmount.AutoSize = true;
            this.VolumeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VolumeAmount.Location = new System.Drawing.Point(82, 337);
            this.VolumeAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VolumeAmount.Name = "VolumeAmount";
            this.VolumeAmount.Size = new System.Drawing.Size(102, 26);
            this.VolumeAmount.TabIndex = 11;
            this.VolumeAmount.Text = "40000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(86, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume:";
            // 
            // LowestPrice
            // 
            this.LowestPrice.AutoSize = true;
            this.LowestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LowestPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LowestPrice.Location = new System.Drawing.Point(166, 254);
            this.LowestPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LowestPrice.Name = "LowestPrice";
            this.LowestPrice.Size = new System.Drawing.Size(76, 20);
            this.LowestPrice.TabIndex = 9;
            this.LowestPrice.Text = "59000.00";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLow.Location = new System.Drawing.Point(177, 222);
            this.labelLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(42, 20);
            this.labelLow.TabIndex = 8;
            this.labelLow.Text = "Low:";
            // 
            // HighestPrice
            // 
            this.HighestPrice.AutoSize = true;
            this.HighestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HighestPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HighestPrice.Location = new System.Drawing.Point(29, 254);
            this.HighestPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HighestPrice.Name = "HighestPrice";
            this.HighestPrice.Size = new System.Drawing.Size(76, 20);
            this.HighestPrice.TabIndex = 7;
            this.HighestPrice.Text = "61000.00";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHigh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHigh.Location = new System.Drawing.Point(48, 222);
            this.labelHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(46, 20);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "High:";
            // 
            // labelNameOfCurrency
            // 
            this.labelNameOfCurrency.AutoSize = true;
            this.labelNameOfCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameOfCurrency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameOfCurrency.Location = new System.Drawing.Point(184, 162);
            this.labelNameOfCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfCurrency.Name = "labelNameOfCurrency";
            this.labelNameOfCurrency.Size = new System.Drawing.Size(55, 26);
            this.labelNameOfCurrency.TabIndex = 5;
            this.labelNameOfCurrency.Text = "BTC";
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDollar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDollar.Location = new System.Drawing.Point(130, 162);
            this.labelDollar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(49, 26);
            this.labelDollar.TabIndex = 4;
            this.labelDollar.Text = " = 1";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentPrice.Location = new System.Drawing.Point(24, 162);
            this.labelCurrentPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(102, 26);
            this.labelCurrentPrice.TabIndex = 3;
            this.labelCurrentPrice.Text = "60000.00";
            // 
            // DashboardCurrencyPair
            // 
            this.DashboardCurrencyPair.AutoSize = true;
            this.DashboardCurrencyPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DashboardCurrencyPair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardCurrencyPair.Location = new System.Drawing.Point(84, 112);
            this.DashboardCurrencyPair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DashboardCurrencyPair.Name = "DashboardCurrencyPair";
            this.DashboardCurrencyPair.Size = new System.Drawing.Size(108, 26);
            this.DashboardCurrencyPair.TabIndex = 2;
            this.DashboardCurrencyPair.Text = "BTC/USD";
            // 
            // DashboardCurrencyIcon
            // 
            this.DashboardCurrencyIcon.Image = ((System.Drawing.Image)(resources.GetObject("DashboardCurrencyIcon.Image")));
            this.DashboardCurrencyIcon.Location = new System.Drawing.Point(87, 2);
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
            this.panelChooseCrypto.Controls.Add(this.label2);
            this.panelChooseCrypto.Controls.Add(this.pictureBox3);
            this.panelChooseCrypto.Controls.Add(this.pictureBox2);
            this.panelChooseCrypto.Controls.Add(this.pictureBox1);
            this.panelChooseCrypto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChooseCrypto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelChooseCrypto.Location = new System.Drawing.Point(292, 0);
            this.panelChooseCrypto.Margin = new System.Windows.Forms.Padding(2);
            this.panelChooseCrypto.Name = "panelChooseCrypto";
            this.panelChooseCrypto.Size = new System.Drawing.Size(330, 422);
            this.panelChooseCrypto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select cryptocurrency";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(178, 112);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(622, 422);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.PictureBox DashboardCurrencyIcon;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label DashboardCurrencyPair;
        private System.Windows.Forms.Label HighestPrice;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelNameOfCurrency;
        private System.Windows.Forms.Label LowestPrice;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Panel panelChooseCrypto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VolumeAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}