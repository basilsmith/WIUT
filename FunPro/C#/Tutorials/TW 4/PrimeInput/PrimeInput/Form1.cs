using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeInput
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

            //first check if the input is a number
            int result;
            if (int.TryParse(input, out result))
            {
                //check if the number is prime
                bool isPrime = true; //we assume that it's prime by default and check if the number can be divided over anything 
                for (int i = 2; i < result; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                        break; //it's not prime, no point to check further
                    }
                }

                if (isPrime)
                    MessageBox.Show("It's a prime number");
                else
                    MessageBox.Show("It's not a prime number");
            }
            else
                MessageBox.Show("Please enter a number");
        }
    }
}
