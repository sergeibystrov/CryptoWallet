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
    public partial class WalletForm : Form
    {
        bazadanychDataContext bazadanych = new bazadanychDataContext();
        double currentBalance;
        double CurrencyAmount;
        double currentPrice;
        private List<string[]> list = null;
        private List<string[]> filteredList = null;
        private Dictionary<int, string> IdListOfCurrencies = new Dictionary<int, string>();
        public WalletForm()
        {
            InitializeComponent();
        }

        private async void WalletForm_Load(object sender, EventArgs e)
        {
            foreach(User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                currentBalance = u.balance;
                labelBalance.Text = currentBalance.ToString("N");
                foreach(Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach(Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        foreach (Currency c in bazadanych.Currencies.Where(x => x.Id == pr.Id_Currency))
                        {
                            if (!IdListOfCurrencies.ContainsKey(c.Id))
                            {
                                IdListOfCurrencies.Add(c.Id, c.Name);
                            }
                        }
                    }
                }
                list = new List<string[]>();
                string[] row = null;
                foreach (var el in IdListOfCurrencies.Distinct())
                {
                    foreach (Currency o in bazadanych.Currencies.Where(x => x.Id == el.Key))
                    {
                        string priceAPI = "https://min-api.cryptocompare.com/data/price?fsym=" + o.Name + "&tsyms=USD";
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
                        currentPrice = price.USD;
                    }
                    amountOfCurrency(el.Key);
                    row = new string[]
                    {
                                el.Value,
                                CurrencyAmount.ToString(),
                                (CurrencyAmount*currentPrice).ToString("N")
                    };
                    list.Add(row);
                }
                RefreshList(list);
            }
        }
        private void RefreshList(List<string[]> list)
        {
            listView.Items.Clear();

            foreach (string[] s in list)
            {
                listView.Items.Add(new ListViewItem(s));
            }
        }
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

        private void button100_Click(object sender, EventArgs e)
        {
            numericUpDownAddFunds.Value = 100;
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            numericUpDownAddFunds.Value = 1000;
        }

        private void button5000_Click(object sender, EventArgs e)
        {
            numericUpDownAddFunds.Value = 5000;
        }

        private void button10000_Click(object sender, EventArgs e)
        {
            numericUpDownAddFunds.Value = 10000;
        }

        private void buttonAddFunds_Click(object sender, EventArgs e)
        {
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                u.balance += (float)numericUpDownAddFunds.Value;
                bazadanych.SubmitChanges();
                currentBalance += (float)numericUpDownAddFunds.Value;
                labelBalance.Text = currentBalance.ToString("N");
            }
        }
        public static int CompareByNameAZ(string[] x, string[] y)
        {
            return String.Compare(x[0], y[0]);
        }
        public static int CompareByNameZA(string[] x, string[] y)
        {
            return String.Compare(y[0], x[0]);
        }
        public static int CompareByAmountLowest(string[] x, string[] y)
        {
            return Double.Parse(x[1]).CompareTo(Double.Parse(y[1]));
        }
        public static int CompareByAmountHighest(string[] x, string[] y)
        {
            return Double.Parse(y[1]).CompareTo(Double.Parse(x[1]));
        }
        public static int CompareByPriceLowest(string[] x, string[] y)
        {
            return Double.Parse(x[2]).CompareTo(Double.Parse(y[2]));
        }
        public static int CompareByPriceHighest(string[] x, string[] y)
        {
            return Double.Parse(y[2]).CompareTo(Double.Parse(x[2]));
        }
        private void comboBoxSortedBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBoxSortedBy.SelectedIndex)
            {
                case 0:
                    list.Sort(CompareByNameAZ);
                    break;
                case 1:
                    list.Sort(CompareByNameZA);
                    break;
                case 2:
                    list.Sort(CompareByAmountHighest);
                    break;
                case 3:
                    list.Sort(CompareByAmountLowest);
                    break;
                case 4:
                    list.Sort(CompareByPriceHighest);
                    break;
                case 5:
                    list.Sort(CompareByPriceLowest);
                    break;
            }
            RefreshList(list);
        }
    }
}
