using System;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMiles_Click(object sender, EventArgs e)
        {
            //validate - should be positive number
            var input = tbxMeters.Text;
            if (IsNumeric(input) && double.Parse(input) > 0)
            {
                var meters = double.Parse(input);

                //calculate
                var miles = meters / 1610;
                
                //show to user
                MessageBox.Show($"{meters} meters = {miles:N2} miles");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            //validate - should be positive number
            var input = tbxMeters.Text;
            if (IsNumeric(input) && double.Parse(input) > 0)
            {
                var meters = double.Parse(input);

                //calculate
                var feet = meters / 0.3048;

                //show to user
                MessageBox.Show($"{meters} meters = {feet:N2} feet");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnInches_Click(object sender, EventArgs e)
        {
            //validate - should be positive number
            var input = tbxMeters.Text;
            if (IsNumeric(input) && double.Parse(input) > 0)
            {
                var meters = double.Parse(input);

                //calculate
                var inches = meters / 0.0254;

                //show to user
                MessageBox.Show($"{meters} meters = {inches:N2} inches");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
