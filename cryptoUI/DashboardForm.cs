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
        }
        public class Currencies
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public string ImageUrl { get; set; }
        }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
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
            labelPriceInPLN.Text = price.PLN.ToString() + "PLN";

            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            
            foreach (Currency o in bazadanych.Currencies)
            {
                myCollection.Add(o.Name);
            }

            textBox1.AutoCompleteCustomSource = myCollection;
        }
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach (Currency o in bazadanych.Currencies.Where(x => x.Name == textBox1.Text))
            {
                //DODAC WARUNEK GDY ImageURL = NULL !!!!!!!!!!!!!!!!!!!!!!!
                string Url = "https://www.cryptocompare.com" + o.ImageUrl;
                var request = WebRequest.Create(Url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    DashboardCurrencyIcon.Image = Bitmap.FromStream(stream);
                }
                textBoxPriceInUSD.Text = o.Name+"/USD";
                textBoxPriceInEUR.Text = o.Name + "/EUR";
                textBoxPriceInPLN.Text = o.Name + "/PLN";
                
                string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym="+o.Name+"&tsyms=USD,EUR,PLN";
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

                labelPriceInUSD.Text = price.USD.ToString()+"$";
                labelPriceInEUR.Text = price.EUR.ToString() + "€";
                labelPriceInPLN.Text = price.PLN.ToString() + "PLN";
            }
        }
    }
}
