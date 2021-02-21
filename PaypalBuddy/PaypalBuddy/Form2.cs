using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaypalBuddy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitChart();
        }
        private void InitChart()
        {
            List<Rate> fullRates = new List<Rate>();
            var daysCount = (Convert.ToDateTime(Form1.Rates.First().DateOfRate) - Convert.ToDateTime(Form1.Rates.Last().DateOfRate)).TotalDays;

            int mark = 0;
            for (int i = 0; i < daysCount; i++)
            {
                fullRates.Add(new Rate(Convert.ToDateTime(
                    Form1.Rates.Last().DateOfRate).AddDays(i).ToString(), 
                    Form1.Rates[Form1.Rates.Count - 1 - mark].CurrencyRate)
                    );

                var dayFromData = Convert.ToDateTime(Form1.Rates[Form1.Rates.Count - 1 - mark - 1].DateOfRate).Day;
                var dayToCmp = (Convert.ToDateTime(Form1.Rates.Last().DateOfRate).AddDays(i + 1)).Day;
                if (dayFromData == dayToCmp)
                {
                    mark++;
                }
            }

            foreach (var item in fullRates)
            {
                chart1.Series["Currency"].Points.AddXY(
                    Convert.ToDateTime(item.DateOfRate).Month + 
                    "-" + 
                    Convert.ToDateTime(item.DateOfRate).Day, (Math.Round( 1 / Convert.ToDouble(item.CurrencyRate), 4)));
            }

            chart1.Series["Currency"].IsVisibleInLegend = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
            chart1.ChartAreas[0].AxisX.Interval = 2;

            //set Y axis range
            List<double> rates = new List<double>();
            foreach (var item in fullRates)
            {
                rates.Add(1/Convert.ToDouble(item.CurrencyRate));
            }
            chart1.ChartAreas[0].AxisY.Maximum = Math.Round(rates.Max(),2) + 0.01;
            chart1.ChartAreas[0].AxisY.Minimum = Math.Round(rates.Min(),2) - 0.01;

            //chart title  
            chart1.Titles.Add("Currency Rate Chart - Month Interval");
        }
    }
}
