using System;
using System.Windows.Forms;

namespace Exchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //validate
            if (double.TryParse(tbxAmount.Text, out var amountEur))
            {
                if (amountEur > 0)
                {
                    //constants
                    const double exchangeRate  = 1.317;
                    const double exchangeFee = 1.25 / 100; //1.25%

                    //calculate
                    var exchangedDollars = amountEur * exchangeRate;
                    var fee = exchangedDollars * exchangeFee;
                    var payableDollars = exchangedDollars - fee;

                    //show the result
                    var message  = $@"
Amount received: {amountEur} EUR
Exchange rate: {exchangeRate}
Exchanged amount: {exchangedDollars:N2}
USD Exchage fee: {fee:N2}
USD Amount payable: {payableDollars:N1}0 USD";//rounded to 1 decimal place and 0 is added at the end to round up to the nearest 10 cents
                    lblResult.Text = message;
                }
                else
                    MessageBox.Show("Please enter proper amount");
            }
            else //invalid input
                MessageBox.Show("Please enter a number");
        }
    }
}
