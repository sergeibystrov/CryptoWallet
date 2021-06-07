using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace cryptoUI
{
    public partial class ChartsForm : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        string CurrentCurrency;
        string ApiLink;
        public string Nickname;
        double CurrencyAmount;
        double MoneySpent;
        public string UsernameText
        {
            get
            {
                return this.Nickname;
            }
            set
            {
                this.Nickname = value;
            }
        }
        public ChartsForm()
        {
            InitializeComponent();
        }

        private void ChartsForm_LoadAsync(object sender, EventArgs e)
        {
            CurrentCurrency = "BTC";
            labelNameCoin.Text = CurrentCurrency;
            textBoxListOfCurrencies.Text = CurrentCurrency;
            comboBoxListOfTimeframes.SelectedItem = "Hourly [4 days]";
            ApiLink = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + CurrentCurrency + "&tsym=USD&limit=96";
            UpdateChart();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }
            textBoxListOfCurrencies.AutoCompleteCustomSource = myCollection;
        }

        private async void buttonShowChart_Click(object sender, EventArgs e)
        {
            CurrentCurrency = textBoxListOfCurrencies.Text;
            switch (comboBoxListOfTimeframes.SelectedIndex)
            {
                case 0:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + CurrentCurrency + "&tsym=USD&limit=96";
                    UpdateChart();
                    break;
                case 1:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + CurrentCurrency + "&tsym=USD&limit=100";
                    UpdateChart();
                    break;
                case 2:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + CurrentCurrency + "&tsym=USD&limit=365";
                    UpdateChart();
                    break;
            }
        }

        private async void UpdateChart()
        {
            this.chartPrice.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
            this.chartPrice.ChartAreas["ChartArea1"].CursorY.IsUserEnabled = true;
            this.chartPrice.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            this.chartPrice.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;
            this.chartPrice.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            this.chartPrice.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            this.chartPrice.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            this.chartPrice.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;
            this.chartPrice.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonColor = Color.Gold;
            this.chartPrice.ChartAreas["ChartArea1"].AxisY.ScrollBar.ButtonColor = Color.Gold;

            this.chartRevenue.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
            this.chartRevenue.ChartAreas["ChartArea1"].CursorY.IsUserEnabled = true;
            this.chartRevenue.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            this.chartRevenue.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonColor = Color.Gold;
            this.chartRevenue.ChartAreas["ChartArea1"].AxisY.ScrollBar.ButtonColor = Color.Gold;

            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBoxListOfCurrencies.Text))
            {
                richTextBoxInfoFromPriceChart.Text = "";
                richTextBoxInfoFromRevenueChart.Text = "";
                labelNameCoin.Text = CurrentCurrency;
                WebRequest request = WebRequest.Create(ApiLink);
                WebResponse response = await request.GetResponseAsync();
                string answer = string.Empty;
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                response.Close();
                Coins.HistoricalData hd = JsonConvert.DeserializeObject<Coins.HistoricalData>(answer);
                chartPrice.Series["Daily"].Points.Clear();
                chartRevenue.Series["Series"].Points.Clear();
                chartRevenue.Series["Series"].BorderWidth = 5;
                chartRevenue.Series["Series"].Color = Color.Gold;
                chartPrice.Series["Daily"].XValueMember = "Day";
                chartPrice.Series["Daily"].YValueMembers = "High,Low,Open,Close";
                chartPrice.Series["Daily"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                chartPrice.Series["Daily"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
                foreach (var d in hd.Data.Data)
                {
                    System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTime = dtDateTime.AddSeconds(d.time).ToLocalTime();

                    richTextBoxInfoFromPriceChart.Text += "Date " + dtDateTime.ToString() + "\n";
                    richTextBoxInfoFromPriceChart.Text += "High " + d.high.ToString("N") + "$\n";
                    richTextBoxInfoFromPriceChart.Text += "Low " + d.low.ToString("N") + "$\n";
                    richTextBoxInfoFromPriceChart.Text += "Open " + d.open.ToString("N") + "$\n";
                    richTextBoxInfoFromPriceChart.Text += "Close " + d.close.ToString("N") + "$\n\n";
                    
                    chartPrice.Series["Daily"].Points.AddXY(dtDateTime, d.high, d.low, d.open, d.close);

                    CurrencyAmount = 0;
                    MoneySpent = 0;
                    foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
                    {
                        foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                        {
                            foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                            {
                                if (pr.Id_Currency == o.Id && pr.DataTime <= dtDateTime)
                                {
                                    CurrencyAmount += p.amount;
                                    MoneySpent += Math.Round(p.amount * pr.Price1, 2);
                                }
                            }
                        }
                    }
                    
                    chartRevenue.Series["Series"].Points.AddXY(dtDateTime, Math.Round((CurrencyAmount * d.open) - MoneySpent, 2));
                    richTextBoxInfoFromRevenueChart.Text += "Date " + dtDateTime.ToString() + "\n";
                    richTextBoxInfoFromRevenueChart.Text += "Revenue " + ((CurrencyAmount * d.open) - MoneySpent).ToString("N") + "$\n\n";
                }
            }
        }
    }
}
