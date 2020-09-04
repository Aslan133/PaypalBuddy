using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaypalBuddy
{
    public static class DataAccessHelper
    {
        #region Properties

        #endregion

        #region Public Methods
        public static string GetTodayRate(string todayCurrUrl)
        {
            try
            {
                string rate = null;
                var htmlresult = GetHTML(todayCurrUrl);

                rate = htmlresult
                    .Split(new string[] { "from=USD&amp;to=EUR'>" }, StringSplitOptions.None)[1]
                    .Split(new string[] { "</a></td>" }, StringSplitOptions.None)[0];

                return rate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public static string[] GetPreviousRatesCurr(string lastCurrUrl)
        //{
        //    try
        //    {
        //        string currencyRateWebsiteUrl_other_full = lastCurrUrl
        //                                                        + DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd")
        //                                                        + "&date_to_day="
        //                                                        + DateTime.Now.ToString("yyyy-MM-dd");


        //        var htmlresult2 = GetHTML(currencyRateWebsiteUrl_other_full);

        //        //var tempp = GetPreviousRatesObj(htmlresult2);
        //        //string[] rates = new string[tempp.Count];

        //        //for (int i = 0; i < tempp.Count; i++)
        //        //{
        //        //    rates[i] = tempp[i].CurrencyRate;
        //        //}

        //        return rates;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        
        public static List<Rate> GetPreviousRates(string url)
        {
            List<Rate> rates = new List<Rate>();

            try
            {
                var htmlString = GetHTML(url);

                string[] temp = htmlString.Split(new string[] { "<td class=\"cur-col-w100\">" }, StringSplitOptions.None);

                for (int i = 0; i < temp.Count(); i++)
                {
                    if (i % 3 == 1)
                    {
                        rates.Add(new Rate
                            (
                                temp[i].Split(new string[] { "</td>" }, StringSplitOptions.None)[0]
                                       .Split('\n')[1]
                                       .Split('\n')[0],
                                temp[i].Split(new string[] { "<span>" }, StringSplitOptions.None)[1]
                                       .Split(new string[] { "</span>" }, StringSplitOptions.None)[0]
                                       .Split('\n')[1]
                                       .Split('\n')[0]
                            ));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return rates;
        }
        #endregion

        #region Private Methods
        private static string GetHTML(string url)
        {
            try
            {
                string html = null;

                HtmlWeb webpage = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument webdoc = webpage.Load(url);
                html = webdoc.DocumentNode.InnerHtml;

                return html;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
    public class Rate
    {
        public string DateOfRate { get; set; }
        public string CurrencyRate { get; set; }

        public Rate(string date, string rate)
        {
            DateOfRate = date;
            CurrencyRate = rate;
        }
    }
}
