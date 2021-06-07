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
using Newtonsoft.Json.Linq;

namespace cryptoUI
{
    public partial class DashboardForm : Form
    {
        double CurrentPrice;
        double CurrentBalance;
        double CurrentAmount;
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        string CurrentCurrency;
        int id_currency;
        float amount;
        public async void UpdateDashboard()
        {
            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBoxListOfCurrencies.Text))
            {
                string Url = "https://www.cryptocompare.com" + o.ImageUrl;
                var request = WebRequest.Create(Url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    DashboardCurrencyIcon.Image = Bitmap.FromStream(stream);
                }

                textBoxPriceInUSD.Text = o.Name + "/USD";

                string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym=" + CurrentCurrency + "&tsyms=USD";
                WebRequest request3 = WebRequest.Create(priceAPI);

                WebResponse response3 = await request3.GetResponseAsync();

                string answer = string.Empty;

                using (Stream s = response3.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }


                Coins.Price price = JsonConvert.DeserializeObject<Coins.Price>(answer);
                CurrentPrice = price.USD;
                labelPriceInUSD.Text = CurrentPrice.ToString("N") + "$";
                response3.Close();

                foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
                {
                    id_currency = c.Id;
                }
                foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
                {
                    CurrentBalance = Math.Round(u.balance, 2);
                    usdBalance.Text = "USD balance: " + Math.Round(CurrentBalance, 2).ToString("N") + "$";
                }
                amountOfCurrency();
                CurrentAmount = amount;
                tokenBalance.Text = "Token balance: " + amount.ToString();
            }
        }
        public DashboardForm()
        {
            InitializeComponent();
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            textBoxListOfCurrencies.Text = "BTC";
            CurrentCurrency = "BTC";
            UpdateDashboard();

            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }

            textBoxListOfCurrencies.AutoCompleteCustomSource = myCollection;


            foreach (User o in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                CurrentBalance = o.balance;
                usdBalance.Text += Math.Round(CurrentBalance, 2).ToString("N") + "$";
            }

            foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
            {
                id_currency = c.Id;
            }
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
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private async void buttonCheckCoin_Click(object sender, EventArgs e)
        {
            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBoxListOfCurrencies.Text))
            {
                CurrentCurrency = o.Name;
                UpdateDashboard();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {     
            foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
            {
                id_currency = c.Id;
            }
            Price newPrice = new Price();
            newPrice.Id_Currency = id_currency;
            UpdateDashboard();
            newPrice.Price1 = (float)CurrentPrice;
            newPrice.DataTime = DateTime.Now;
            bazadanych.Prices.InsertOnSubmit(newPrice);
            bazadanych.SubmitChanges();

            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                if (usdPaid.Text.Length != 0 && tokenToBuy.Text.Length != 0)
                {
                    if (u.balance >= float.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any))
                    {
                        u.balance -= float.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any);
                        Payment newPayment = new Payment();
                        u.Payments.Add(newPayment);
                        newPayment.id_price = newPrice.Id;
                        newPayment.amount = float.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                        UpdateDashboard();
                        tokenToBuy.Text = "";
                        usdPaid.Text = "";

                        this.Alert("Transaction completed", AlertForm.enmType.TransactionCompleted);
                    }
                    else
                    {
                        this.Alert("Not enough money", AlertForm.enmType.NotEnoughMoney);
                    }
                }
            }
            bazadanych.SubmitChanges();
        }

        private void amountOfCurrency()
        {
            amount = 0;
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        if (pr.Id_Currency == id_currency)
                        {
                            amount += p.amount;
                        }
                    }
                }
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
            {
                id_currency = c.Id;
            }
            Price newPrice = new Price();
            newPrice.Id_Currency = id_currency;
            UpdateDashboard();
            newPrice.Price1 = (float)CurrentPrice;
            newPrice.DataTime = DateTime.Now;
            bazadanych.Prices.InsertOnSubmit(newPrice);
            bazadanych.SubmitChanges();

            amountOfCurrency();

            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                if (tokenToSell.Text.Length != 0 && usdEarn.Text.Length != 0)
                {
                    if (amount >= float.Parse(tokenToSell.Text, System.Globalization.NumberStyles.Any))
                    {
                        u.balance += float.Parse(usdEarn.Text, System.Globalization.NumberStyles.Any);
                        Payment newPayment = new Payment();
                        u.Payments.Add(newPayment);
                        newPayment.id_price = newPrice.Id;
                        newPayment.amount = -float.Parse(tokenToSell.Text, System.Globalization.NumberStyles.Any);
                        UpdateDashboard();
                        tokenToSell.Text = "";
                        usdEarn.Text = "";

                        this.Alert("Transaction completed", AlertForm.enmType.TransactionCompleted);
                    }
                    else
                    {
                        this.Alert("Not enough tokens", AlertForm.enmType.NotEnoughTokens);
                    }
                }
            }
            bazadanych.SubmitChanges();
        }

        private void tokenToBuy_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl))
            {
                //bad input
            }
            else
            {
                //double value OK
                UpdateDashboard();
                float amount = float.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                float price = (float)CurrentPrice;
                usdPaid.Text = (amount * price).ToString();
            }
        }

        private void usdPaid_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl))
            {
                //bad input
            }
            else
            {
                //double value OK
                UpdateDashboard();
                double priceToSpend = Double.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any);
                double price = (double)CurrentPrice;
                tokenToBuy.Text = (priceToSpend / price).ToString();
            }
        }

        private void tokenToSell_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl))
            {
                //bad input
            }
            else
            {
                //double value OK
                UpdateDashboard();
                double amount = double.Parse(tokenToSell.Text, System.Globalization.NumberStyles.Any);
                double price = (double)CurrentPrice;
                usdEarn.Text = (amount * price).ToString();
            }
        }

        private void usdEarn_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl))
            {
                //bad input
            }
            else
            {
                //double value OK
                UpdateDashboard();
                double priceToEarn = Double.Parse(usdEarn.Text, System.Globalization.NumberStyles.Any);
                double price = (double)CurrentPrice;
                tokenToSell.Text = (priceToEarn / price).ToString();
            }
        }

        private void usdBalance_Click(object sender, EventArgs e)
        {
            usdPaid.Text = CurrentBalance.ToString();
        }

        private void tokenBalance_Click(object sender, EventArgs e)
        {
            tokenToSell.Text = CurrentAmount.ToString();
        }
        public void Alert(string msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
        }
    }
}
