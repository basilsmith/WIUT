using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text;

            //validating
            int number;
            if (!int.TryParse(input, out number) || number <= 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            //go through the series until we get a number which is greater then the user's input
            var previousNumber = 0; //initial value
            var currentNumber = 1; //initial value
            var nextNumber = previousNumber + currentNumber;
            while (number > nextNumber) //termination condition
            {
                //reset for the next iteration
                previousNumber = currentNumber;
                currentNumber = nextNumber;
                nextNumber = previousNumber + currentNumber;
            }

            //if we are here we have reached a Fibonacci number which is equal or bigger then the given number
            if (number == nextNumber)
                MessageBox.Show($"{number} is a Fibonacci number");
            else
            {
                //need to know the closest number
                int closestNumber;
                if (nextNumber - number < number - currentNumber) //next number is closer
                    closestNumber = nextNumber;
                else 
                    closestNumber = currentNumber;
                MessageBox.Show($"{number} is NOT a Fibonacci number, closest Fibonacci number is {closestNumber}");
            }
        }
    }
}
