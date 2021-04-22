
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
            this.labelNameOfCurrency = new System.Windows.Forms.Label();
            this.labelDollar = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.DashboardCurrencyPair = new System.Windows.Forms.Label();
            this.DashboardCurrencyIcon = new System.Windows.Forms.PictureBox();
            this.panelChooseCrypto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panelChooseCrypto.Controls.Add(this.button1);
            this.panelChooseCrypto.Controls.Add(this.textBox1);
            this.panelChooseCrypto.Controls.Add(this.label2);
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
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert cryptocurrency";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.PictureBox DashboardCurrencyIcon;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label DashboardCurrencyPair;
        private System.Windows.Forms.Label labelNameOfCurrency;
        private System.Windows.Forms.Panel panelChooseCrypto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}