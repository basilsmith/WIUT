using System;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the input
            var input1 = tbxNumber1.Text;
            var input2 = tbxNumber2.Text;

            //validate and convert
            var hasValidationErrors = false;

            int number1 = 0;
            switch (input1)
            {
                case "zero":
                    number1 = 0;
                    break;
                case "one":
                    number1 = 1;
                    break;
                case "two":
                    number1 = 2;
                    break;
                case "three":
                    number1 = 3;
                    break;
                case "four":
                    number1 = 4;
                    break;
                case "five":
                    number1 = 5;
                    break;
                case "six":
                    number1 = 6;
                    break;
                case "seven":
                    number1 = 7;
                    break;
                case "eight":
                    number1 = 8;
                    break;
                case "nine":
                    number1 = 9;
                    break;
                default:
                    MessageBox.Show("Please enter correct number for input 1");
                    hasValidationErrors = true;
                    break;
            }

            int number2 = 0;
            switch (input2)
            {
                case "zero":
                    number2 = 0;
                    break;
                case "one":
                    number2 = 1;
                    break;
                case "two":
                    number2 = 2;
                    break;
                case "three":
                    number2 = 3;
                    break;
                case "four":
                    number2 = 4;
                    break;
                case "five":
                    number2 = 5;
                    break;
                case "six":
                    number2 = 6;
                    break;
                case "seven":
                    number2 = 7;
                    break;
                case "eight":
                    number2 = 8;
                    break;
                case "nine":
                    number2 = 9;
                    break;
                default:
                    MessageBox.Show("Please enter correct number for input 2");
                    hasValidationErrors = true;
                    break;
            }

            //only if the input is valid
            if (!hasValidationErrors)
            {
                //actual calculation
                var result = number1 + number2;
                lblResult.Text = Convert.ToString(result);
            }
        }
    }
}
