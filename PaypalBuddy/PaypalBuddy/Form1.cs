using HtmlAgilityPack;
using Microsoft.Win32;
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
        
        private string _currencyToday;
        private bool Work;
        private CancellationTokenSource cts;
        private DateTime _otherRatesUpdated;

        public static List<Rate> Rates = null;
        #endregion

        #region Properties
        public string CurrencyToday { 
            get { return _currencyToday; } 
            set
            {
                _currencyToday = value;

                if (value != null)
                {
                    OnCurrencyUpdated();
                }
            }
        }
        #endregion

        #region Events
        public event EventHandler CurrencyUpdated;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            InitProps();
            StartCheck();
        }
        #endregion
        #region Private methods
        private async void StartCheck()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            try
            {
                while (Work)
                {
                    //get today rate
                    CurrencyToday = await Task.Run(() =>
                    {
                        //Thread.Sleep(Int32.Parse(txtUpdateFrequency.Text) * 1000);

                        try
                        {
                            Task.Delay(Int32.Parse(txtUpdateFrequency.Text) * 1000, token).Wait();
                            return PaypalBuddy.DataAccessHelper.GetTodayRate(_currencyRateWebsiteUrl_today);
                        }
                        catch (Exception)
                        {
                            Work = false;
                            return null;
                        }
                    }, token);

                    if (CurrencyToday != null)
                    {
                        lblCurrencyRateNo1.Text = CurrencyToday;

                        lblCurrencyRateNo1.ForeColor = Color.Black;
                        lblLastUpdate.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblCurrencyRateNo1.ForeColor = Color.Red;
                        lblLastUpdate.ForeColor = Color.Red;
                    }

                    if (DateTime.Now.Day != _otherRatesUpdated.Day)
                    {
                        SetOtherCurrencies();
                    }
                }
            }
            catch (Exception)
            {
                Work = false;
            }

        }
        private async void InitProps()
        {
            //enable something
            Work = true;

            //disable something
            btnShowAllCurrData.Enabled = false;

            //init Events
            CurrencyUpdated += UpdateCurrUpdatedDate;
            SystemEvents.PowerModeChanged += OnPowerChange;

            //init settings
            txtUpdateFrequency.Text = "10";

            //set current rate
            SetCurrentCurrency();

            //set toher currencies
            SetOtherCurrencies();
        }
        private void OnCancel()
        {
            cts.Cancel();

        }
        private async void SetOtherCurrencies()
        {
            string currencyRateWebsiteUrl_other = @"https://www.lb.lt/lt/currency?currency=USD&class=Eu&type=day&date_from_day="
                                                                + DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd")
                                                                + "&date_to_day="
                                                                + DateTime.Now.ToString("yyyy-MM-dd");

            //get previous rates
            Rates = await Task.Run(() =>
            {
                return PaypalBuddy.DataAccessHelper.GetPreviousRates(currencyRateWebsiteUrl_other);
            });

            if (Rates != null)
            {
                lblCurrencyRateNo2.Text = Math.Round(1 / float.Parse(Rates[1].CurrencyRate), 4).ToString();
                lblCurr2Date.Text = Rates[1].DateOfRate;
                lblCurrencyRateNo3.Text = Math.Round(1 / float.Parse(Rates[2].CurrencyRate), 4).ToString();
                lblCurr3Date.Text = Rates[2].DateOfRate;
                lblCurrencyRateNo4.Text = Math.Round(1 / float.Parse(Rates[3].CurrencyRate), 4).ToString();
                lblCurr4Date.Text = Rates[3].DateOfRate;

                btnShowAllCurrData.Enabled = true;

                _otherRatesUpdated = DateTime.Now;

                lblCurrencyRateNo2.ForeColor = Color.Black;
                lblCurr2Date.ForeColor = Color.Black;
                lblCurrencyRateNo3.ForeColor = Color.Black;
                lblCurr3Date.ForeColor = Color.Black;
                lblCurrencyRateNo4.ForeColor = Color.Black;
                lblCurr4Date.ForeColor = Color.Black;
            } else
            {
                lblCurrencyRateNo2.ForeColor = Color.Red;
                lblCurr2Date.ForeColor = Color.Red;
                lblCurrencyRateNo3.ForeColor = Color.Red;
                lblCurr3Date.ForeColor = Color.Red;
                lblCurrencyRateNo4.ForeColor = Color.Red;
                lblCurr4Date.ForeColor = Color.Red;
            }
        }
        private async void SetCurrentCurrency()
        {
            //get today rate
            CurrencyToday = await Task.Run(() =>
            {
                return PaypalBuddy.DataAccessHelper.GetTodayRate(_currencyRateWebsiteUrl_today);
            });

            if (CurrencyToday != null)
            {
                lblCurrencyRateNo1.Text = CurrencyToday;

                lblCurrencyRateNo1.ForeColor = Color.Black;
                lblLastUpdate.ForeColor = Color.Black;
            }
            else
            {
                lblCurrencyRateNo1.ForeColor = Color.Red;
                lblLastUpdate.ForeColor = Color.Red;
            }
        }
        private void OnCurrencyUpdated()
        {
            if (CurrencyUpdated != null) CurrencyUpdated(this, EventArgs.Empty);
        }
        private void UpdateCurrUpdatedDate(object sender, System.EventArgs e)
        {
            lblLastUpdate.Text = DateTime.Now.ToString();
        }
        private void OnPowerChange(object s, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    Work = true;
                    SetCurrentCurrency();
                    StartCheck();
                    break;
                case PowerModes.Suspend:
                    OnCancel();
                    Work = false;
                    break;
            }
        }
        #endregion
        #region Event Handlers
        private void txtUpdateFrequency_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;

            if (!Int32.TryParse(txtUpdateFrequency.Text, out temp))
            {
                txtUpdateFrequency.Text = "3600";
            } 
            else if(temp == 0)
            {
                txtUpdateFrequency.Text = "3600";
            }
        }
        #endregion

        private void btnShowAllCurrData_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
