using System;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //1900 - No
            //2000 - Yes
            //2016 - Yes
            //1981 - No

            var year = Convert.ToInt32(tbxYear.Text);
            bool isLeap;
            if (year > 1582)
                if (year % 4 == 0)
                    if (year % 100 == 0)
                        if (year % 400 == 0)
                            isLeap = true;
                        else
                            isLeap = false;
                    else
                        isLeap = true;
                else
                    isLeap = false;
            else
                isLeap = false;

            if (isLeap)
                MessageBox.Show("It's a leap year");
            else
                MessageBox.Show("It's not a leap year");
        }
    }
}
