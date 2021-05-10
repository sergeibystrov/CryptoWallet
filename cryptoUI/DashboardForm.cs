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
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        string CurrentCurrency;
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
            string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym=" + CurrentCurrency + "&tsyms=USD,EUR";
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

            labelPriceInUSD.Text = Decimal.Parse(price.USD.ToString(), System.Globalization.NumberStyles.Any).ToString() + "$"; ; //price.USD.ToString()+"$";
            labelPriceInEUR.Text = Decimal.Parse(price.EUR.ToString(), System.Globalization.NumberStyles.Any).ToString() + "€"; ; //price.EUR.ToString() + "€";
            response3.Close();
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
            WebRequest request2 = WebRequest.Create("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD,EUR,PLN");

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

            labelPriceInUSD.Text = price.USD.ToString() + "$";
            labelPriceInEUR.Text = price.EUR.ToString() + "€";

            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }
            CurrentCurrency = "BTC";

            textBox1.AutoCompleteCustomSource = myCollection;


            foreach (User o in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                usdBalance.Text += o.balance.ToString() + "$";
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
                textBoxPriceInEUR.Text = o.Name + "/EUR";
                
                string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym="+o.Name+"&tsyms=USD,EUR";
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

                labelPriceInUSD.Text = Decimal.Parse(price.USD.ToString(), System.Globalization.NumberStyles.Any).ToString() + "$"; ; //price.USD.ToString()+"$";
                labelPriceInEUR.Text = Decimal.Parse(price.EUR.ToString(), System.Globalization.NumberStyles.Any).ToString()+"€"; ; //price.EUR.ToString() + "€";
                CurrentCurrency = o.Name;
            }
        }

        private void tokenToBuy_KeyPress(object sender, KeyPressEventArgs e)
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
                double amount = Double.Parse(tokenToBuy.Text, System.Globalization.NumberStyles.Any);
                double price = Double.Parse(labelPriceInUSD.Text, System.Globalization.NumberStyles.Any);
                usdPaid.Text = (amount * price).ToString();
            }
        }

        private void usdPaid_KeyPress(object sender, KeyPressEventArgs e)
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
                double price = Double.Parse(labelPriceInUSD.Text, System.Globalization.NumberStyles.Any);
                tokenToBuy.Text = (priceToSpend/price).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
                {
                    Wallet newWallet = new Wallet();
                    newWallet.id_user = u.id_user;
                    newWallet.adress = "adasdsa123dsd";
                    bazadanych.Wallets.InsertOnSubmit(newWallet);
                    bazadanych.SubmitChanges();
                }



            
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
    }
}
