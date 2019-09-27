using System;
using System.Windows.Forms;

namespace ExpressionEvaluation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get user input
            var input = tbxInput.Text;

            //validate and calculate
            var result = 0;

            //should have {Number}{Operand}{Number}{Operand}{Number}
            //so we need a variable to check which one is now
            var isNumberNow = true;

            //we allow only + or -
            //so we need a variable to record next operation
            var isPlus = true;

            //check each character
            foreach (var c in input)
            {
                if (isNumberNow)
                {
                    //only allow digits
                    if (char.IsDigit(c))
                    {
                        // convert character to number
                        var number = int.Parse(c.ToString());
                        if (isPlus)
                        {
                            result = result + number;
                        }
                        else
                        {
                            result = result - number;
                        }

                    }
                    else
                    {
                        //invalid
                        MessageBox.Show("Invalid input");
                        return;
                    }
                }
                else
                {
                    //+ or - only
                    switch (c)
                    {
                        case '+':
                            isPlus = true;
                            break;
                        case '-':
                            isPlus = false;
                            break;
                        default:
                            MessageBox.Show("Invalid input");
                            return;
                    }
                }

                // reset turn
                isNumberNow = !isNumberNow;
            }

            // by now we have result ready
            lblResult.Text = result.ToString();
        }
    }
}
