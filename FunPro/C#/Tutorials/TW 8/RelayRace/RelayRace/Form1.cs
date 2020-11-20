using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelayRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get the input
            var time1AsString = tbxTime1.Text;
            var time2AsString = tbxTime2.Text;

            //validating
            //simplest way to do it is to cast it to DateTime in mm:ss format
            //it will take care of all edge cases (minutes or seconds being more then 60 etc.)
            DateTime time1AsDate;
            if (!DateTime.TryParseExact(time1AsString, "mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out time1AsDate))
            {
                MessageBox.Show("Invalid time 1");
                Application.Exit(); //should terminate in case of invalid input
                return;
            }
            DateTime time2AsDate;
            if (!DateTime.TryParseExact(time2AsString, "mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out time2AsDate))
            {
                MessageBox.Show("Invalid time 2");
                Application.Exit(); //should terminate in case of invalid input
                return;
            }

            //if we are here - input is valid, time to calculate
            //best way to deal with time is to use TimeSpan
            //so we take it from the corresponding DateTimes
            var time1 = time1AsDate.TimeOfDay;
            var time2 = time2AsDate.TimeOfDay;
            var result = time1.Add(time2);

            //show it to the user
            //we need to use TotalMinutes as just Minutes will not show correct value if spans over an hour
            //e.g. 45 minutes + 20 minutes = 1 hour and 5 minutes, but TotalMinutes will show 65
            //yet we need to round it down as TotalMinutes is a double and will be rounded up if seconds are more then 30
            MessageBox.Show($"Total time is - {Math.Floor(result.TotalMinutes):00}:{result.Seconds:00}");
        }
    }
}
