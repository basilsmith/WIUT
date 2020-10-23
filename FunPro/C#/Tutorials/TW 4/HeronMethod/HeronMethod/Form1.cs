using System;
using System.Windows.Forms;

namespace HeronMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var target = (int)nudInput.Value;

            var guess = 1.0; //universal initial guess
            while (Math.Abs(guess * guess - target) > 0.01)
                guess = (guess + target / guess) / 2; // update the guess with better guess

            MessageBox.Show("Square root is " + Math.Sqrt(target) + "\nGuess is " + guess);
        }
    }
}