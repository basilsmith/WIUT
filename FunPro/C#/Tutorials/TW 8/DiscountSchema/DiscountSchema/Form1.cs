using System;
using System.Windows.Forms;

namespace DiscountSchema
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
            var amountAsString = tbxAmount.Text;
            var hasDiscountCard = chbDiscount.Checked;

            //validate - should be a positive number
            double amount;
            if (double.TryParse(amountAsString, out amount) && amount > 0)
            {
                //details of the schemas
                double discount;
                if (hasDiscountCard)
                {
                    if (amount < 5000)
                        discount = 0;
                    else if (amount < 15000)
                        discount = 0.015;
                    else if (amount < 30000)
                        discount = 0.025;
                    else if (amount < 55000)
                        discount = 0.035;
                    else
                        discount = 0.045;
                }
                else
                {
                    if (amount < 10000)
                        discount = 0;
                    else if (amount < 20000)
                        discount = 0.01;
                    else if (amount < 35000)
                        discount = 0.02;
                    else if (amount < 60000)
                        discount = 0.03;
                    else
                        discount = 0.04;
                }

                var discountedAmount = amount * (1 - discount);
                MessageBox.Show($"Discounted amount is: {discountedAmount:C2}");
            }
            else
            {
                MessageBox.Show("Invalid amount");
                Application.Exit(); //should terminate in case of invalid input
            }
        }
    }
}
