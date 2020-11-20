using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeRounding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //getting input
            var roundingInterval = nudRoundingInterval.Value;
            var inHours = nudInHours.Value;
            var inMinutes = nudInMinutes.Value;
            var outHours = nudOutHours.Value;
            var outMinutes = nudOutMinutes.Value;

            //validating
            if (roundingInterval < 10 || roundingInterval > 30)
            {
                MessageBox.Show("Invalid rounding interval");
                return;
            }

            if (inHours > 23)
            {
                MessageBox.Show("Invalid IN hours");
                return;
            }

            if (outHours > 23)
            {
                MessageBox.Show("Invalid OUT hours");
                return;
            }

            if (inMinutes > 59)
            {
                MessageBox.Show("Invalid IN minutes");
                return;
            }

            if (outMinutes > 59)
            {
                MessageBox.Show("Invalid OUT minutes");
                return;
            }

            //rounding
            RoundMinutes(roundingInterval, ref inMinutes); //IN time
            RoundMinutes(roundingInterval, ref outMinutes); //OUT time

            //the simplest way to handle time is to use TimeSpans
            var inTime = new TimeSpan((int) inHours, (int) inMinutes, 0);
            var outTime = new TimeSpan((int) outHours, (int) outMinutes, 0);

            //calculating the result
            var netPresence = outTime.Subtract(inTime);

            //show it to the user
            MessageBox.Show($"Net presence is {netPresence.Hours:00}:{netPresence.Minutes:00}");
        }

        private void RoundMinutes(decimal roundingInterval, ref decimal minutes)
        {
            var inRemainder = minutes % roundingInterval;
            if (inRemainder >= roundingInterval / 2)
                minutes = Math.Ceiling(minutes / roundingInterval) * roundingInterval; //round up
            else
                minutes = Math.Floor(minutes / roundingInterval) * roundingInterval; //round down
        }
    }
}
