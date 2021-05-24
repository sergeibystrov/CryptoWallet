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
            /*
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

            StringBuilder kek = new StringBuilder();

            foreach (var el in coins.Data.Values)
            {
                JToken o = (JToken)el;

                kek.Append(o.ToString(Formatting.None));

            }

            string str = kek.ToString();

            IList<Currencies> list = new List<Currencies>();

            JsonTextReader reader1 = new JsonTextReader(new StringReader(str));
            reader1.SupportMultipleContent = true;

            while (true)
            {
                if (!reader1.Read())
                {
                    break;
                }

                JsonSerializer serializer = new JsonSerializer();
                var cur = serializer.Deserialize<Currencies>(reader1);
                list.Add(cur);
            }

            foreach (var el in list)
            {
                Currency newCurrency = new Currency();
                newCurrency.API_Id = int.Parse(el.Id);
                newCurrency.Name = el.Name.ToString();
                newCurrency.ImageUrl = el.ImageUrl;
                bazadanych.Currencies.InsertOnSubmit(newCurrency);
                bazadanych.SubmitChanges();
            }
            
             push all names of currencies to database
            foreach (var i in coins.Data)
            {
                Currency newCurrency = new Currency();
                newCurrency.Name = i.Key;
                bazadanych.Currencies.InsertOnSubmit(newCurrency);
                bazadanych.SubmitChanges();
            }
            
            foreach (Currency o in bazadanych.Currencies.Where(x=>x.Name==textBox1.Text))
            {
                var request = WebRequest.Create("https://www.cryptocompare.com" + o.ImageUrl);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    DashboardCurrencyIcon.Image = Bitmap.FromStream(stream);
                }
            }*/
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
            foreach (User o in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                CurrentBalance = o.balance;
                usdBalance.Text = "USD balance: " + Math.Round(CurrentBalance, 2).ToString() + "$";
            }
            amountOfCurrency();
            tokenBalance.Text = "Token balance: " + amount.ToString();
        }
        /*public class Currencies
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public string ImageUrl { get; set; }
        }*/
        public DashboardForm()
        {
            InitializeComponent();
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            //UpdateDashboard();
            WebRequest request2 = WebRequest.Create("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD");

            WebResponse response2 = await request2.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response2.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }

            response2.Close();

            Coins.Price price = JsonConvert.DeserializeObject<Coins.Price>(answer);

            CurrentPrice = price.USD;
            labelPriceInUSD.Text = CurrentPrice.ToString("N") + "$";

            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }
            CurrentCurrency = "BTC";

            textBox1.AutoCompleteCustomSource = myCollection;


            foreach (User o in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                CurrentBalance = o.balance;
                usdBalance.Text += Math.Round(CurrentBalance, 2).ToString() + "$";
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

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBox1.Text))
            {
                string Url = "https://www.cryptocompare.com" + o.ImageUrl;
                var request = WebRequest.Create(Url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    DashboardCurrencyIcon.Image = Bitmap.FromStream(stream);
                }
                textBoxPriceInUSD.Text = o.Name+"/USD";
                
                string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym="+o.Name+"&tsyms=USD";
                WebRequest request2 = WebRequest.Create(priceAPI);

                WebResponse response2 = await request2.GetResponseAsync();

                string answer = string.Empty;

                using (Stream s = response2.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }

                response2.Close();

                Coins.Price price = JsonConvert.DeserializeObject<Coins.Price>(answer);

                CurrentPrice = price.USD;
                labelPriceInUSD.Text = CurrentPrice.ToString("N") + "$";
                CurrentCurrency = o.Name;

                foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
                {
                    id_currency = c.Id;
                }

                amountOfCurrency();

                CurrentAmount = amount;
                tokenBalance.Text = "Token balance: " + amount.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                    //messege: payment done
                }
                else
                {
                    //messege: to low balance
                }
            }
            bazadanych.SubmitChanges();


            /*foreach (User o in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                if (o.balance >= float.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any))
                {
                    o.balance -= float.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any);
                }
                foreach (var k in bazadanych.Wallets.Where(x => x.id_user == o.id_user))
                {
                    foreach (var b in bazadanych.Possessions.Where(x => x.id_wallet ==k.id_wallet))
                    {
                        if (b.amount >= 0)
                        {
                            b.amount += float.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                        }
                        else
                        {
                            b.amount = float.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                        }
                        foreach (var m in bazadanych.Currencies.Where(x => x.Name == CurrentCurrency))
                        {
                            b.id_currency = m.Id;
                            b.id_wallet = k.id_wallet;
                            foreach (var n in bazadanych.Payments.Where(x => x.id_wallet == b.id_wallet))
                            {
                                n.id_wallet = b.id_wallet;
                                n.id_currency = m.Id;
                                n.amount = float.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                                n.price = float.Parse(usdPaid.Text, System.Globalization.NumberStyles.Any);
                            }
                        }
                    }
                }
            }*/
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

        private void button3_Click(object sender, EventArgs e)
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
                    //messege: payment done
                }
                else
                {
                    //messege: to low amount of currency on your balance
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
                //handle bad input
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
                //handle bad input
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
                //handle bad input
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
                //handle bad input
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
    }
}
