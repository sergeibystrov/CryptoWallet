
namespace cryptoUI
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.richTextBoxInfoFromPriceChart = new System.Windows.Forms.RichTextBox();
            this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxListOfCurrencies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameCoin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListOfTimeframes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxInfoFromRevenueChart = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfoFromPriceChart
            // 
            this.richTextBoxInfoFromPriceChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.richTextBoxInfoFromPriceChart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxInfoFromPriceChart.Location = new System.Drawing.Point(824, 171);
            this.richTextBoxInfoFromPriceChart.Name = "richTextBoxInfoFromPriceChart";
            this.richTextBoxInfoFromPriceChart.ReadOnly = true;
            this.richTextBoxInfoFromPriceChart.Size = new System.Drawing.Size(180, 184);
            this.richTextBoxInfoFromPriceChart.TabIndex = 1;
            this.richTextBoxInfoFromPriceChart.Text = "";
            // 
            // chartPrice
            // 
            this.chartPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea1.Name = "ChartArea1";
            this.chartPrice.ChartAreas.Add(chartArea1);
            this.chartPrice.Location = new System.Drawing.Point(9, 12);
            this.chartPrice.Name = "chartPrice";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Name = "Daily";
            series1.YValuesPerPoint = 4;
            this.chartPrice.Series.Add(series1);
            this.chartPrice.Size = new System.Drawing.Size(805, 359);
            this.chartPrice.TabIndex = 2;
            this.chartPrice.Text = "chart1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(827, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonShowChart_Click);
            // 
            // textBoxListOfCurrencies
            // 
            this.textBoxListOfCurrencies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxListOfCurrencies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxListOfCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBoxListOfCurrencies.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxListOfCurrencies.Location = new System.Drawing.Point(827, 36);
            this.textBoxListOfCurrencies.Name = "textBoxListOfCurrencies";
            this.textBoxListOfCurrencies.Size = new System.Drawing.Size(117, 20);
            this.textBoxListOfCurrencies.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(819, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose cryptocurrency";
            // 
            // labelNameCoin
            // 
            this.labelNameCoin.AutoSize = true;
            this.labelNameCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCoin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNameCoin.Location = new System.Drawing.Point(393, 8);
            this.labelNameCoin.Name = "labelNameCoin";
            this.labelNameCoin.Size = new System.Drawing.Size(70, 25);
            this.labelNameCoin.TabIndex = 9;
            this.labelNameCoin.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(823, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose timeframe";
            // 
            // comboBoxListOfTimeframes
            // 
            this.comboBoxListOfTimeframes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBoxListOfTimeframes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxListOfTimeframes.FormattingEnabled = true;
            this.comboBoxListOfTimeframes.Items.AddRange(new object[] {
            "Hourly [4 days]",
            "Daily [3 months]",
            "Daily [year]"});
            this.comboBoxListOfTimeframes.Location = new System.Drawing.Point(827, 83);
            this.comboBoxListOfTimeframes.Name = "comboBoxListOfTimeframes";
            this.comboBoxListOfTimeframes.Size = new System.Drawing.Size(120, 21);
            this.comboBoxListOfTimeframes.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(836, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Info from chart";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(9, 369);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(805, 249);
            this.chartRevenue.TabIndex = 14;
            this.chartRevenue.Text = "chart2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(835, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Info from chart";
            // 
            // richTextBoxInfoFromRevenueChart
            // 
            this.richTextBoxInfoFromRevenueChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.richTextBoxInfoFromRevenueChart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxInfoFromRevenueChart.Location = new System.Drawing.Point(823, 418);
            this.richTextBoxInfoFromRevenueChart.Name = "richTextBoxInfoFromRevenueChart";
            this.richTextBoxInfoFromRevenueChart.ReadOnly = true;
            this.richTextBoxInfoFromRevenueChart.Size = new System.Drawing.Size(181, 200);
            this.richTextBoxInfoFromRevenueChart.TabIndex = 15;
            this.richTextBoxInfoFromRevenueChart.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(380, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Revenue";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1176, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxInfoFromRevenueChart);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxListOfTimeframes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameCoin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxListOfCurrencies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPrice);
            this.Controls.Add(this.richTextBoxInfoFromPriceChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChartsForm";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.ChartsForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxInfoFromPriceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxListOfCurrencies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNameCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListOfTimeframes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxInfoFromRevenueChart;
        private System.Windows.Forms.Label label5;
    }
}