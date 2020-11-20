using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammersDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var yearAsString = tbxInput.Text;

            //validating
            int year;
            if (!int.TryParse(yearAsString, out year))
            {
                MessageBox.Show("Invalid input");
                Application.Exit(); //terminate in case of invalid input
                return;
            }

            //ready to calculate
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
                lblResult.Text = "Programmers' day is celebrated on 12th of September";
            else
                lblResult.Text = "Programmers' day is celebrated on 13th of September";
        }
    }
}
