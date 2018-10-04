using System;
using System.Windows.Forms;

namespace Numerology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var input = tbxDob.Text;
            DateTime result;
            //validate
            if (DateTime.TryParse(input, out result))
            {
                DateTime dob = Convert.ToDateTime(input);
                int number = (dob.Year + dob.Month + dob.Day);

                //sum up digits
                while (number > 9)
                {
                    int sumOfDigits = 0;
                    while (number > 0)
                    {
                        int lastDigit = number % 10;
                        sumOfDigits += lastDigit;

                        //remove last digit from the number
                        number = number / 10;
                    }
                    //reset number to the current sum
                    number = sumOfDigits;
                }

                //by now we have a correct number
                string personType;
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        personType = "vampire";
                        break;
                    case 5:
                    case 6:
                    case 7:
                        personType = "neutral";
                        break;
                    default:
                        personType = "angel";
                        break;
                }
                
                //show the result
                lblNumber.Text = Convert.ToString(number);
                lblType.Text = personType;
            }

            else
                //invalid input
                MessageBox.Show("Please enter correct date");
        }
    }
}
