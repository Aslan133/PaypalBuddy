using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaypalBuddy
{
    public partial class Form1 : Form
    {
        #region Variables
        private static string _currencyRateWebsiteUrl_today = @"https://www.x-rates.com/table/?from=USD&amount=1";
        private static string _currencyRateWebsiteUrl_other = @"https://www.lb.lt/lt/currency?currency=USD&class=Eu&type=day&date_from_day="
                                                                + DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd")
                                                                + "&date_to_day="
                                                                + DateTime.Now.ToString("yyyy-MM-dd");
        #endregion

        #region Properties
        public List<Rate> Rates = null;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            InitProps();
        }
        #endregion
        #region Private methods
        private async void StartServer()
        {
            await Task.Run(() =>
            {
                //_arduinoAsyncSocketListener.StartServer();
            });
        }
        private async void InitProps()
        {
            //get today rate
            lblCurrencyRateNo1.Text = await Task.Run(() =>
            {
                return PaypalBuddy.DataAccessHelper.GetTodayRate(_currencyRateWebsiteUrl_today);
            });

            //get previous rates
            var prevRates = await Task.Run(() =>
            {
                return PaypalBuddy.DataAccessHelper.GetPreviousRates(_currencyRateWebsiteUrl_other);
            });

            lblCurrencyRateNo2.Text = prevRates[0].CurrencyRate + " : " + prevRates[0].DateOfRate;
            lblCurrencyRateNo3.Text = prevRates[1].CurrencyRate + " : " + prevRates[1].DateOfRate;
            lblCurrencyRateNo4.Text = prevRates[2].CurrencyRate + " : " + prevRates[2].DateOfRate;
        }
        #endregion
        #region Event Handlers
        private async void button1_Click(object sender, EventArgs e)
        {
            
            while (false)
            {
                string currencyRate = await Task.Run(() => 
                {
                    Thread.Sleep(1000);
                    return "";
                });
            }

            //PaypalBuddy.DataAccessHelper.GetRate(lblCurrencyRateNo1);

        }

        #endregion
    }
}
