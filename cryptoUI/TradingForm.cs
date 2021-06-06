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
        private List<string[]> list = null;
        private List<string[]> filteredList = null;

        public TradingForm()
        {
            InitializeComponent();
            labelFrom.Hide();
            labelTo.Hide();
            dateTimePickerFrom.Hide();
            dateTimePickerTo.Hide();
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
            list = new List<string[]>();
            string[] row = null;
            foreach (User u in bazadanych.Users.Where(x => x.username == UsernameText))
            {
                foreach (Payment p in bazadanych.Payments.Where(x => x.id_user == u.id_user))
                {
                    foreach (Price pr in bazadanych.Prices.Where(x => x.Id == p.id_price))
                    {
                        foreach (Currency c in bazadanych.Currencies.Where(x => x.Id == pr.Id_Currency))
                        {
                            row = new string[]
                            {
                                pr.DataTime.ToString(),
                                c.Name,
                                p.amount.ToString(),
                                pr.Price1.ToString("N")
                            };
                            list.Add(row);

                            USDspent += p.amount * pr.Price1;
                        }
                    }
                }
            }
            RefreshList(list);
            List<string> distinct = (List<string>)list.Select(x => x[1]).Distinct().ToList();
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

            foreach (var el in prices)
            {
                foreach (Currency c in bazadanych.Currencies.Where(x => x.Name == el.Key))
                {
                    amountOfCurrency(c.Id);
                    CurrentPrice += CurrencyAmount * el.Value;
                }
            }
            Revenue = CurrentPrice - USDspent;
            double cena = Math.Round(Revenue, 2);
            double procent = Math.Round(((Revenue * 100) / USDspent), 2);

            if (cena > 0)
            {
                pictureBoxRevenue.Image = Properties.Resources.increase;
                labelRevenueInDollars.Text = "+" + cena.ToString("N") + "$";
                labelRevenueInProcent.Text = "+" + procent.ToString() + "%";
                labelRevenueInDollars.ForeColor = Color.Green;
                labelRevenueInProcent.ForeColor = Color.Green;
            }
            else
            {
                pictureBoxRevenue.Image = Properties.Resources.decrease;
                labelRevenueInDollars.Text = cena.ToString("N") + "$";
                labelRevenueInProcent.Text = procent.ToString() + "%";
                labelRevenueInDollars.ForeColor = Color.Red;
                labelRevenueInProcent.ForeColor = Color.Red;
            }
        }

        private void RefreshList(List<string[]> list)
        {
            listView1.Items.Clear();

            foreach (string[] s in list)
            {
                listView1.Items.Add(new ListViewItem(s));
            }
        }

        public static int CompareByDateRecent(string[] x, string[] y)
        {
            return DateTime.Compare(DateTime.Parse(y[0]), DateTime.Parse(x[0]));
        }
        public static int CompareByDateOldest(string[] x, string[] y)
        {
            return DateTime.Compare(DateTime.Parse(x[0]), DateTime.Parse(y[0]));
        }
        public static int CompareByNameAZ(string[] x, string[] y)
        {
            return String.Compare(x[1], y[1]);
        }
        public static int CompareByNameZA(string[] x, string[] y)
        {
            return String.Compare(y[1], x[1]);
        }
        public static int CompareByAmountLowest(string[] x, string[] y)
        {
            return Double.Parse(x[2]).CompareTo(Double.Parse(y[2]));
        }
        public static int CompareByAmountHighest(string[] x, string[] y)
        {
            return Double.Parse(y[2]).CompareTo(Double.Parse(x[2]));
        }
        public static int CompareByPriceLowest(string[] x, string[] y)
        {
            return Double.Parse(x[3]).CompareTo(Double.Parse(y[3]));
        }
        public static int CompareByPriceHighest(string[] x, string[] y)
        {
            return Double.Parse(y[3]).CompareTo(Double.Parse(x[3]));
        }

        private void comboBoxSortedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDateRange.SelectedItem == "All time" || comboBoxDateRange.SelectedItem == null)
            {
                switch (comboBoxSortedBy.SelectedIndex)
                {
                    case 0:
                        list.Sort(CompareByDateRecent);
                        break;
                    case 1:
                        list.Sort(CompareByDateOldest);
                        break;
                    case 2:
                        list.Sort(CompareByNameAZ);
                        break;
                    case 3:
                        list.Sort(CompareByNameZA);
                        break;
                    case 4:
                        list.Sort(CompareByAmountHighest);
                        break;
                    case 5:
                        list.Sort(CompareByAmountLowest);
                        break;
                    case 6:
                        list.Sort(CompareByPriceHighest);
                        break;
                    case 7:
                        list.Sort(CompareByPriceLowest);
                        break;
                }
                RefreshList(list);
            }
            else
            {
                switch (comboBoxSortedBy.SelectedIndex)
                {
                    case 0:
                        filteredList.Sort(CompareByDateRecent);
                        break;
                    case 1:
                        filteredList.Sort(CompareByDateOldest);
                        break;
                    case 2:
                        filteredList.Sort(CompareByNameAZ);
                        break;
                    case 3:
                        filteredList.Sort(CompareByNameZA);
                        break;
                    case 4:
                        filteredList.Sort(CompareByAmountHighest);
                        break;
                    case 5:
                        filteredList.Sort(CompareByAmountLowest);
                        break;
                    case 6:
                        filteredList.Sort(CompareByPriceHighest);
                        break;
                    case 7:
                        filteredList.Sort(CompareByPriceLowest);
                        break;
                }
                RefreshList(filteredList);
            }
        }

        private void comboBoxDateRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDateRange.SelectedIndex)
            {
                case 0:
                    filteredList = list;
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    break;
                case 1:
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]).Year == DateTime.Now.Year &&
                                                                     DateTime.Parse(x[0]).Month == DateTime.Now.Month &&
                                                                     DateTime.Parse(x[0]).Day == DateTime.Now.Day).ToList();
                    break;
                case 2:
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]).Year == DateTime.Now.Year &&
                                                                     DateTime.Parse(x[0]).Month == DateTime.Now.Month &&
                                                                     DateTime.Parse(x[0]).Day == DateTime.Now.AddDays(-1).Day).ToList();
                    break;
                case 3:
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]) >= DateTime.Now.AddDays(-7)).ToList();
                    break;
                case 4:
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]) >= DateTime.Now.AddDays(-30)).ToList();
                    break;
                case 5:
                    labelFrom.Hide();
                    labelTo.Hide();
                    dateTimePickerFrom.Hide();
                    dateTimePickerTo.Hide();
                    filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]) >= DateTime.Now.AddYears(-1)).ToList();
                    break;
                case 6:
                    labelFrom.Show();
                    labelTo.Show();
                    dateTimePickerFrom.Show();
                    dateTimePickerTo.Show();

                    filteredList = list;

                    dateTimePickerTo.Value = DateTime.Today;
                    dateTimePickerFrom.Value = DateTime.Today;
                    dateTimePickerFrom.MaxDate = dateTimePickerTo.Value;
                    dateTimePickerTo.MinDate = dateTimePickerFrom.Value;
                    dateTimePickerTo.MaxDate = DateTime.Today;
                    break;
            }
            RefreshList(filteredList);
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.MinDate = dateTimePickerFrom.Value;

            filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]) >= dateTimePickerFrom.Value &&
                                                             DateTime.Parse(x[0]) < dateTimePickerTo.Value.AddDays(1)).ToList();
            RefreshList(filteredList);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.MaxDate = dateTimePickerTo.Value;

            filteredList = (List<string[]>)list.Where((x) => DateTime.Parse(x[0]) >= dateTimePickerFrom.Value &&
                                                             DateTime.Parse(x[0]) < dateTimePickerTo.Value.AddDays(1)).ToList();
            RefreshList(filteredList);
        }
    }
}
