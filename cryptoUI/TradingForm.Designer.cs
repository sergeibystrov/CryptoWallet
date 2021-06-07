
namespace cryptoUI
{
    partial class TradingForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSortedBy = new System.Windows.Forms.ComboBox();
            this.labelRevenueInDollars = new System.Windows.Forms.Label();
            this.labelRevenueInProcent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDateRange = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 390);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 52;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 390);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxSortedBy
            // 
            this.comboBoxSortedBy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.comboBoxSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortedBy.ForeColor = System.Drawing.Color.Gold;
            this.comboBoxSortedBy.FormattingEnabled = true;
            this.comboBoxSortedBy.Items.AddRange(new object[] {
            "Date: recent",
            "Date: oldest",
            "Name: A->Z",
            "Name: Z->A",
            "Amount: highest",
            "Amount: lowest",
            "Price: highest",
            "Price: lowest"});
            this.comboBoxSortedBy.Location = new System.Drawing.Point(651, 166);
            this.comboBoxSortedBy.Name = "comboBoxSortedBy";
            this.comboBoxSortedBy.Size = new System.Drawing.Size(154, 24);
            this.comboBoxSortedBy.TabIndex = 6;
            this.comboBoxSortedBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortedBy_SelectedIndexChanged);
            // 
            // labelRevenueInDollars
            // 
            this.labelRevenueInDollars.AutoSize = true;
            this.labelRevenueInDollars.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueInDollars.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRevenueInDollars.Location = new System.Drawing.Point(668, 44);
            this.labelRevenueInDollars.Name = "labelRevenueInDollars";
            this.labelRevenueInDollars.Size = new System.Drawing.Size(0, 46);
            this.labelRevenueInDollars.TabIndex = 3;
            // 
            // labelRevenueInProcent
            // 
            this.labelRevenueInProcent.AutoSize = true;
            this.labelRevenueInProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenueInProcent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelRevenueInProcent.Location = new System.Drawing.Point(675, 90);
            this.labelRevenueInProcent.Name = "labelRevenueInProcent";
            this.labelRevenueInProcent.Size = new System.Drawing.Size(0, 25);
            this.labelRevenueInProcent.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(525, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorted by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(525, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date range";
            // 
            // comboBoxDateRange
            // 
            this.comboBoxDateRange.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.comboBoxDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDateRange.ForeColor = System.Drawing.Color.Gold;
            this.comboBoxDateRange.FormattingEnabled = true;
            this.comboBoxDateRange.Items.AddRange(new object[] {
            "All time",
            "Today",
            "Yesterday",
            "Last 7 Days",
            "Last 30 Days",
            "Last Year",
            "Custom Range"});
            this.comboBoxDateRange.Location = new System.Drawing.Point(676, 219);
            this.comboBoxDateRange.Name = "comboBoxDateRange";
            this.comboBoxDateRange.Size = new System.Drawing.Size(129, 24);
            this.comboBoxDateRange.TabIndex = 9;
            this.comboBoxDateRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateRange_SelectedIndexChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarMonthBackground = System.Drawing.Color.DarkSlateBlue;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(605, 267);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 10;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarMonthBackground = System.Drawing.Color.DarkSlateBlue;
            this.dateTimePickerTo.Location = new System.Drawing.Point(605, 293);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 11;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.labelFrom.Location = new System.Drawing.Point(525, 258);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(77, 31);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.labelTo.Location = new System.Drawing.Point(525, 284);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(46, 31);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "To";
            // 
            // pictureBoxRevenue
            // 
            this.pictureBoxRevenue.Image = global::cryptoUI.Properties.Resources.increase;
            this.pictureBoxRevenue.Location = new System.Drawing.Point(531, 12);
            this.pictureBoxRevenue.Name = "pictureBoxRevenue";
            this.pictureBoxRevenue.Size = new System.Drawing.Size(131, 134);
            this.pictureBoxRevenue.TabIndex = 2;
            this.pictureBoxRevenue.TabStop = false;
            // 
            // TradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(873, 414);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.comboBoxDateRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRevenueInProcent);
            this.Controls.Add(this.comboBoxSortedBy);
            this.Controls.Add(this.labelRevenueInDollars);
            this.Controls.Add(this.pictureBoxRevenue);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TradingForm";
            this.Text = "Trading";
            this.Load += new System.EventHandler(this.TradingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRevenueInDollars;
        private System.Windows.Forms.Label labelRevenueInProcent;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
        private System.Windows.Forms.ComboBox comboBoxSortedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
    }
}