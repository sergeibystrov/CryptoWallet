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
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        public async void UpdateDashboard()
        {
            WebRequest request = WebRequest.Create("https://min-api.cryptocompare.com/data/all/coinlist?api_key=007eae4491b499a6771a2f18f4350a8759cf946d02a4b65d62a185ee3dc14341");

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

            /* push all names of currencies to database
            foreach (var i in coins.Data)
            {
                Currency newCurrency = new Currency();
                newCurrency.Name = i.Key;
                bazadanych.Currencies.InsertOnSubmit(newCurrency);
                bazadanych.SubmitChanges();
            }
            */

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
