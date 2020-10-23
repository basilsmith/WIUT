using System;
using System.Windows.Forms;

namespace InerestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var deposit = nudDeposit.Value;
            var rate = nudRate.Value;
            var years = nudYears.Value;

            var balance = deposit;

            for (int i = 0; i < years; i++)
            {
                var interest = balance * rate / 100;
                balance += interest;
            }

            lblResult.Text = balance.ToString();
        }
    }
}
