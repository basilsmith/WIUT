using System;
using System.Windows.Forms;

namespace ShowDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var input = Convert.ToInt32(tbxInput.Text);

            var result = "";

            while (input > 0)
            {
                //get last digit
                var lastDigit = input % 10;

                //update result
                result += lastDigit + "\n";

                //remove last digit from the input string
                input = input / 10; //integer division - no fraction point or rounding
            }

            MessageBox.Show(result);
        }
    }
}
