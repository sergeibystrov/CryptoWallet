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
            textBox1.Text = CurrentCurrency;
            comboBox1.SelectedItem = "Day[Hourly]";
            ApiLink = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + CurrentCurrency + "&tsym=USD&limit=24";
            UpdateChart();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }
            textBox1.AutoCompleteCustomSource = myCollection;
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Revenue r in bazadanych.Revenues.Where(x => x.Id_User == u.id_user))
                {
                    chart2.Series["Series"].Points.AddXY(r.DateTime, r.Revenue1);
                    chart2.Series["Series"].BorderWidth = 5;
                    richTextBox2.Text += "Date " + r.DateTime.ToString() + "\n";
                    richTextBox2.Text += "Revenue " + r.Revenue1.ToString() + "$\n\n";
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CurrentCurrency = textBox1.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + CurrentCurrency + "&tsym=USD&limit=24";
                    UpdateChart();
                    break;
                case 1:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + CurrentCurrency + "&tsym=USD&limit=7";
                    UpdateChart();
                    break;
                case 2:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + CurrentCurrency + "&tsym=USD&limit=30";
                    UpdateChart();
                    break;
                case 3:
                    ApiLink = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + CurrentCurrency + "&tsym=USD&limit=365";
                    UpdateChart();
                    break;
            }
        }

        private async void UpdateChart()
        {
            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBox1.Text))
            {
                ////////////////////////
                richTextBox1.Text = "";
                ///////////////////////
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
                chart1.Series["Daily"].Points.Clear();
                chart1.Series["Daily"].XValueMember = "Day";
                chart1.Series["Daily"].YValueMembers = "High,Low,Open,Close";
                chart1.Series["Daily"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                chart1.Series["Daily"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
                foreach (var d in hd.Data.Data)
                {
                    System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTime = dtDateTime.AddSeconds(d.time).ToLocalTime();

                    ///////////////////////////
                    richTextBox1.Text += "Date " + dtDateTime.ToString() + "\n";
                    richTextBox1.Text += "High " + d.high.ToString("N") + "$\n";
                    richTextBox1.Text += "Low " + d.low.ToString("N") + "$\n";
                    richTextBox1.Text += "Open " + d.open.ToString("N") + "$\n";
                    richTextBox1.Text += "Close " + d.close.ToString("N") + "$\n\n";
                    ///////////////////////////
                    
                    chart1.Series["Daily"].Points.AddXY(dtDateTime, d.high, d.low, d.open, d.close);
                }
            }
        }
    }
}
