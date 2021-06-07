
namespace cryptoUI
{
    partial class WalletForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buttonAddFunds = new System.Windows.Forms.Button();
            this.numericUpDownAddFunds = new System.Windows.Forms.NumericUpDown();
            this.button100 = new System.Windows.Forms.Button();
            this.button1000 = new System.Windows.Forms.Button();
            this.button5000 = new System.Windows.Forms.Button();
            this.button10000 = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSortedBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of currencies on your account";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label.Location = new System.Drawing.Point(349, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Your balance: ";
            // 
            // buttonAddFunds
            // 
            this.buttonAddFunds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.buttonAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFunds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.buttonAddFunds.Location = new System.Drawing.Point(354, 37);
            this.buttonAddFunds.Name = "buttonAddFunds";
            this.buttonAddFunds.Size = new System.Drawing.Size(96, 27);
            this.buttonAddFunds.TabIndex = 3;
            this.buttonAddFunds.Text = "Add funds";
            this.buttonAddFunds.UseVisualStyleBackColor = false;
            this.buttonAddFunds.Click += new System.EventHandler(this.buttonAddFunds_Click);
            // 
            // numericUpDownAddFunds
            // 
            this.numericUpDownAddFunds.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.numericUpDownAddFunds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAddFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAddFunds.ForeColor = System.Drawing.Color.Gold;
            this.numericUpDownAddFunds.Location = new System.Drawing.Point(456, 38);
            this.numericUpDownAddFunds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAddFunds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAddFunds.Name = "numericUpDownAddFunds";
            this.numericUpDownAddFunds.Size = new System.Drawing.Size(121, 27);
            this.numericUpDownAddFunds.TabIndex = 4;
            this.numericUpDownAddFunds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button100
            // 
            this.button100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.button100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.button100.Location = new System.Drawing.Point(354, 70);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(96, 27);
            this.button100.TabIndex = 6;
            this.button100.Text = "100$";
            this.button100.UseVisualStyleBackColor = false;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button1000
            // 
            this.button1000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.button1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.button1000.Location = new System.Drawing.Point(475, 70);
            this.button1000.Name = "button1000";
            this.button1000.Size = new System.Drawing.Size(96, 27);
            this.button1000.TabIndex = 7;
            this.button1000.Text = "1.000$";
            this.button1000.UseVisualStyleBackColor = false;
            this.button1000.Click += new System.EventHandler(this.button1000_Click);
            // 
            // button5000
            // 
            this.button5000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.button5000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.button5000.Location = new System.Drawing.Point(354, 103);
            this.button5000.Name = "button5000";
            this.button5000.Size = new System.Drawing.Size(96, 27);
            this.button5000.TabIndex = 8;
            this.button5000.Text = "5.000$";
            this.button5000.UseVisualStyleBackColor = false;
            this.button5000.Click += new System.EventHandler(this.button5000_Click);
            // 
            // button10000
            // 
            this.button10000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.button10000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.button10000.Location = new System.Drawing.Point(475, 103);
            this.button10000.Name = "button10000";
            this.button10000.Size = new System.Drawing.Size(96, 27);
            this.button10000.TabIndex = 9;
            this.button10000.Text = "10.000$";
            this.button10000.UseVisualStyleBackColor = false;
            this.button10000.Click += new System.EventHandler(this.button10000_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.labelBalance.Location = new System.Drawing.Point(491, 9);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(60, 25);
            this.labelBalance.TabIndex = 10;
            this.labelBalance.Text = "300$";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(11, 37);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(332, 177);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(349, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sorted by";
            // 
            // comboBoxSortedBy
            // 
            this.comboBoxSortedBy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.comboBoxSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortedBy.ForeColor = System.Drawing.Color.Gold;
            this.comboBoxSortedBy.FormattingEnabled = true;
            this.comboBoxSortedBy.Items.AddRange(new object[] {
            "Name: A->Z",
            "Name: Z->A",
            "Amount: highest",
            "Amount: lowest",
            "Price: highest",
            "Price: lowest"});
            this.comboBoxSortedBy.Location = new System.Drawing.Point(355, 179);
            this.comboBoxSortedBy.Name = "comboBoxSortedBy";
            this.comboBoxSortedBy.Size = new System.Drawing.Size(124, 24);
            this.comboBoxSortedBy.TabIndex = 12;
            this.comboBoxSortedBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortedBy_SelectedIndexChanged_1);
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(895, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSortedBy);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.button10000);
            this.Controls.Add(this.button5000);
            this.Controls.Add(this.button1000);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.numericUpDownAddFunds);
            this.Controls.Add(this.buttonAddFunds);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WalletForm";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.WalletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonAddFunds;
        private System.Windows.Forms.NumericUpDown numericUpDownAddFunds;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button1000;
        private System.Windows.Forms.Button button5000;
        private System.Windows.Forms.Button button10000;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSortedBy;
    }
}