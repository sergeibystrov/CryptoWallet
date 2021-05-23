using Newtonsoft.Json;
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

namespace cryptoUI
{
    public partial class TradingForm : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        public TradingForm()
        {
            InitializeComponent();

        }

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
        double USDspent;
        double Revenue;
        double CurrentPrice;
        double CurrencyAmount;
        private void amountOfCurrency(int id_currency)
        {
            CurrencyAmount = 0;
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        if (pr.Id_Currency == id_currency)
                        {
                            CurrencyAmount += p.amount;
                        }
                    }
                }
            }
        }

        private async void TradingForm_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        foreach (Currency c in bazadanych.Currencies.Where(x => x.Id == pr.Id_Currency))
                        {
                            ListViewItem item = new ListViewItem(pr.DataTime.ToString());
                            item.SubItems.Add(c.Name);
                            item.SubItems.Add(p.amount.ToString());
                            item.SubItems.Add(pr.Price1.ToString());
                            listView1.Items.Add(item);

                            list.Add(c.Name);

                            USDspent += p.amount * pr.Price1;
                        }
                    }
                }
            }

            List<string> distinct = list.Distinct().ToList();
            Dictionary<string, double> prices = new Dictionary<string, double>();
            foreach (var el in distinct)
            {
                string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym=" + el + "&tsyms=USD";
                WebRequest request = WebRequest.Create(priceAPI);

                WebResponse response = await request.GetResponseAsync();

                string answer = string.Empty;

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                Coins.Price price = JsonConvert.DeserializeObject<Coins.Price>(answer);
                prices.Add(el, price.USD);
                response.Close();
            }
            /*
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        foreach (Currency c in bazadanych.Currencies.Where(x => x.Id == pr.Id_Currency))
                        {
                            USDspent += p.amount * pr.Price1;
                            amountOfCurrency(pr.Id_Currency);
                            foreach (var el in prices.Where(x => x.Key == c.Name))
                            {
                                CurrentPrice += CurrencyAmount * el.Value;
                            }
                        }
                    }
                }
            }
            */
            foreach (var el in prices)
            {
                foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == el.Key))
                {
                    amountOfCurrency(c.Id);
                    CurrentPrice += CurrencyAmount * el.Value;
                }
            }

            Revenue = USDspent - CurrentPrice;

            if (Revenue < 0)
            {
                pictureBox1.Image = Properties.Resources.increase;
                label1.Text = "+" + Math.Round((-Revenue), 3).ToString() + "$";
                label2.Text = "+" + Math.Round((((-Revenue) * 100) / USDspent), 3).ToString() + "%";

            }
            else
            {
                pictureBox1.Image = Properties.Resources.decrease;
                label1.Text = Math.Round((-Revenue), 3).ToString() + "$";
                label2.Text = Math.Round((((-Revenue) * 100) / USDspent), 3).ToString() + "%";
            }
        }
    }
}
