using System;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];
                if (IsNumeric(item))
                {
                    numbers[i] = Convert.ToInt32(item);
                }
                else
                {
                    ShowMessage("Please enter only numbers");
                    return;
                }
            }

            //actual sorting
            var haveChanges = true;
            while (haveChanges)
            {
                //reset
                haveChanges = false;

                //check each pair
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(ref numbers[i], ref numbers[i + 1]);
                        haveChanges = true;
                    }
                }
            }

            //show the result
            var message = string.Join(", ", numbers);
            ShowMessage(message);
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Sorting numbers");
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

        private void Swap(ref int a, ref int b)
        {
            var c = a;
            a = b;
            b = c;
        }
    }
}
