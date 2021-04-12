
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
            buttonUpdate.Location = new System.Drawing.Point(331, 0);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(58, 51);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.UseVisualStyleBackColor = false;
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
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(389, 519);
            this.panelDashBoard.TabIndex = 0;
            // 
            // VolumeAmount
            // 
            this.VolumeAmount.AutoSize = true;
            this.VolumeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VolumeAmount.Location = new System.Drawing.Point(110, 415);
            this.VolumeAmount.Name = "VolumeAmount";
            this.VolumeAmount.Size = new System.Drawing.Size(135, 32);
            this.VolumeAmount.TabIndex = 11;
            this.VolumeAmount.Text = "40000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(115, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume:";
            // 
            // LowestPrice
            // 
            this.LowestPrice.AutoSize = true;
            this.LowestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LowestPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LowestPrice.Location = new System.Drawing.Point(222, 313);
            this.LowestPrice.Name = "LowestPrice";
            this.LowestPrice.Size = new System.Drawing.Size(94, 25);
            this.LowestPrice.TabIndex = 9;
            this.LowestPrice.Text = "59000.00";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLow.Location = new System.Drawing.Point(236, 273);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(54, 25);
            this.labelLow.TabIndex = 8;
            this.labelLow.Text = "Low:";
            // 
            // HighestPrice
            // 
            this.HighestPrice.AutoSize = true;
            this.HighestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HighestPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HighestPrice.Location = new System.Drawing.Point(39, 313);
            this.HighestPrice.Name = "HighestPrice";
            this.HighestPrice.Size = new System.Drawing.Size(94, 25);
            this.HighestPrice.TabIndex = 7;
            this.HighestPrice.Text = "61000.00";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHigh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHigh.Location = new System.Drawing.Point(64, 273);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(58, 25);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "High:";
            // 
            // labelNameOfCurrency
            // 
            this.labelNameOfCurrency.AutoSize = true;
            this.labelNameOfCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameOfCurrency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameOfCurrency.Location = new System.Drawing.Point(245, 199);
            this.labelNameOfCurrency.Name = "labelNameOfCurrency";
            this.labelNameOfCurrency.Size = new System.Drawing.Size(71, 32);
            this.labelNameOfCurrency.TabIndex = 5;
            this.labelNameOfCurrency.Text = "BTC";
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDollar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDollar.Location = new System.Drawing.Point(173, 199);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(77, 32);
            this.labelDollar.TabIndex = 4;
            this.labelDollar.Text = "$ = 1";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentPrice.Location = new System.Drawing.Point(47, 199);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(135, 32);
            this.labelCurrentPrice.TabIndex = 3;
            this.labelCurrentPrice.Text = "60000.00";
            // 
            // DashboardCurrencyPair
            // 
            this.DashboardCurrencyPair.AutoSize = true;
            this.DashboardCurrencyPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DashboardCurrencyPair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardCurrencyPair.Location = new System.Drawing.Point(112, 138);
            this.DashboardCurrencyPair.Name = "DashboardCurrencyPair";
            this.DashboardCurrencyPair.Size = new System.Drawing.Size(138, 32);
            this.DashboardCurrencyPair.TabIndex = 2;
            this.DashboardCurrencyPair.Text = "BTC/USD";
            // 
            // DashboardCurrencyIcon
            // 
            this.DashboardCurrencyIcon.Image = ((System.Drawing.Image)(resources.GetObject("DashboardCurrencyIcon.Image")));
            this.DashboardCurrencyIcon.Location = new System.Drawing.Point(116, 3);
            this.DashboardCurrencyIcon.Name = "DashboardCurrencyIcon";
            this.DashboardCurrencyIcon.Size = new System.Drawing.Size(134, 132);
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
            this.panelChooseCrypto.Location = new System.Drawing.Point(389, 0);
            this.panelChooseCrypto.Name = "panelChooseCrypto";
            this.panelChooseCrypto.Size = new System.Drawing.Size(441, 519);
            this.panelChooseCrypto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(91, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select cryptocurrency";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(237, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(830, 519);
            this.Controls.Add(this.panelChooseCrypto);
            this.Controls.Add(this.panelDashBoard);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
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