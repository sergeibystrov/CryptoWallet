
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
            this.labelPriceInPLN = new System.Windows.Forms.Label();
            this.labelPriceInEUR = new System.Windows.Forms.Label();
            this.textBoxPriceInPLN = new System.Windows.Forms.Label();
            this.textBoxPriceInEUR = new System.Windows.Forms.Label();
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
            this.panelDashBoard.Controls.Add(this.labelPriceInPLN);
            this.panelDashBoard.Controls.Add(this.labelPriceInEUR);
            this.panelDashBoard.Controls.Add(this.textBoxPriceInPLN);
            this.panelDashBoard.Controls.Add(this.textBoxPriceInEUR);
            this.panelDashBoard.Controls.Add(buttonUpdate);
            this.panelDashBoard.Controls.Add(this.labelPriceInUSD);
            this.panelDashBoard.Controls.Add(this.textBoxPriceInUSD);
            this.panelDashBoard.Controls.Add(this.DashboardCurrencyIcon);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Margin = new System.Windows.Forms.Padding(2);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(292, 422);
            this.panelDashBoard.TabIndex = 0;
            // 
            // labelPriceInPLN
            // 
            this.labelPriceInPLN.AutoSize = true;
            this.labelPriceInPLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceInPLN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriceInPLN.Location = new System.Drawing.Point(123, 217);
            this.labelPriceInPLN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceInPLN.Name = "labelPriceInPLN";
            this.labelPriceInPLN.Size = new System.Drawing.Size(102, 26);
            this.labelPriceInPLN.TabIndex = 16;
            this.labelPriceInPLN.Text = "60000.00";
            // 
            // labelPriceInEUR
            // 
            this.labelPriceInEUR.AutoSize = true;
            this.labelPriceInEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceInEUR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriceInEUR.Location = new System.Drawing.Point(123, 170);
            this.labelPriceInEUR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceInEUR.Name = "labelPriceInEUR";
            this.labelPriceInEUR.Size = new System.Drawing.Size(102, 26);
            this.labelPriceInEUR.TabIndex = 15;
            this.labelPriceInEUR.Text = "60000.00";
            // 
            // textBoxPriceInPLN
            // 
            this.textBoxPriceInPLN.AutoSize = true;
            this.textBoxPriceInPLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceInPLN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPriceInPLN.Location = new System.Drawing.Point(11, 217);
            this.textBoxPriceInPLN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxPriceInPLN.Name = "textBoxPriceInPLN";
            this.textBoxPriceInPLN.Size = new System.Drawing.Size(104, 26);
            this.textBoxPriceInPLN.TabIndex = 14;
            this.textBoxPriceInPLN.Text = "BTC/PLN";
            // 
            // textBoxPriceInEUR
            // 
            this.textBoxPriceInEUR.AutoSize = true;
            this.textBoxPriceInEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceInEUR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPriceInEUR.Location = new System.Drawing.Point(11, 170);
            this.textBoxPriceInEUR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxPriceInEUR.Name = "textBoxPriceInEUR";
            this.textBoxPriceInEUR.Size = new System.Drawing.Size(108, 26);
            this.textBoxPriceInEUR.TabIndex = 13;
            this.textBoxPriceInEUR.Text = "BTC/EUR";
            // 
            // labelPriceInUSD
            // 
            this.labelPriceInUSD.AutoSize = true;
            this.labelPriceInUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceInUSD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriceInUSD.Location = new System.Drawing.Point(123, 128);
            this.labelPriceInUSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceInUSD.Name = "labelPriceInUSD";
            this.labelPriceInUSD.Size = new System.Drawing.Size(102, 26);
            this.labelPriceInUSD.TabIndex = 3;
            this.labelPriceInUSD.Text = "60000.00";
            // 
            // textBoxPriceInUSD
            // 
            this.textBoxPriceInUSD.AutoSize = true;
            this.textBoxPriceInUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceInUSD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPriceInUSD.Location = new System.Drawing.Point(11, 128);
            this.textBoxPriceInUSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxPriceInUSD.Name = "textBoxPriceInUSD";
            this.textBoxPriceInUSD.Size = new System.Drawing.Size(108, 26);
            this.textBoxPriceInUSD.TabIndex = 2;
            this.textBoxPriceInUSD.Text = "BTC/USD";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(22, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 78);
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
        private System.Windows.Forms.Label labelPriceInUSD;
        private System.Windows.Forms.Label textBoxPriceInUSD;
        private System.Windows.Forms.Panel panelChooseCrypto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textBoxPriceInPLN;
        private System.Windows.Forms.Label textBoxPriceInEUR;
        private System.Windows.Forms.Label labelPriceInPLN;
        private System.Windows.Forms.Label labelPriceInEUR;
    }
}