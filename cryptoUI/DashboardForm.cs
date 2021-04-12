using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace cryptoUI
{
    public partial class DashboardForm : Form
    {
        public async void UpdateDashboard()
        {
            WebRequest request = WebRequest.Create("https://api.bitaps.com/market/v1/tickers/BINANCE");

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

            Coins.Coins coins = JsonConvert.DeserializeObject<Coins.Coins>(answer);

            
            if (labelNameOfCurrency.Text == "ETH")
            {
                labelCurrentPrice.Text = coins.data.BINANCE.pairs.ETHUSDT.last.ToString() + "$";
                HighestPrice.Text = coins.data.BINANCE.pairs.ETHUSDT.high.ToString() + "$";
                LowestPrice.Text = coins.data.BINANCE.pairs.ETHUSDT.low.ToString() + "$";
                VolumeAmount.Text = coins.data.BINANCE.pairs.ETHUSDT.volume.ToString() + "$";
            }
            else if (labelNameOfCurrency.Text == "BTC")
            {
                labelCurrentPrice.Text = coins.data.BINANCE.pairs.BTCUSDT.last.ToString() + "$";
                HighestPrice.Text = coins.data.BINANCE.pairs.BTCUSDT.high.ToString() + "$";
                LowestPrice.Text = coins.data.BINANCE.pairs.BTCUSDT.low.ToString() + "$";
                VolumeAmount.Text = coins.data.BINANCE.pairs.BTCUSDT.volume.ToString() + "$";
            }
            else if (labelNameOfCurrency.Text == "LTC")
            {
                labelCurrentPrice.Text = coins.data.BINANCE.pairs.LTCUSDT.last.ToString() + "$";
                HighestPrice.Text = coins.data.BINANCE.pairs.LTCUSDT.high.ToString() + "$";
                LowestPrice.Text = coins.data.BINANCE.pairs.LTCUSDT.low.ToString() + "$";
                VolumeAmount.Text = coins.data.BINANCE.pairs.LTCUSDT.volume.ToString() + "$";
            }
        }
        
        public DashboardForm()
        {
            InitializeComponent();
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DashboardCurrencyIcon.Image = Properties.Resources.etf;
            DashboardCurrencyPair.Text = "ETH/USD";
            labelNameOfCurrency.Text = "ETH";
            UpdateDashboard();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashboardCurrencyIcon.Image = Properties.Resources.bitcoin;
            DashboardCurrencyPair.Text = "BTC/USD";
            labelNameOfCurrency.Text = "BTC";
            UpdateDashboard();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DashboardCurrencyIcon.Image = Properties.Resources.litecoin;
            DashboardCurrencyPair.Text = "LTC/USD";
            labelNameOfCurrency.Text = "LTC";
            UpdateDashboard();
        }
    }
}
