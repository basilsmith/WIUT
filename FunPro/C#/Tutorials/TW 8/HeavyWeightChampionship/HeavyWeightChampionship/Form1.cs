using System;
using System.Windows.Forms;

namespace HeavyWeightChampionship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var athleteWeightAsString = tbxAthleteWeight.Text;
            var weightLiftedAsString = tbxWeightLifted.Text;

            //validating
            if (!IsWeightValid(athleteWeightAsString))
            {
                MessageBox.Show("Athlete's weight is invalid");
                Application.Exit(); //terminate in case of invalid input
                return;
            }

            if (!IsWeightValid(weightLiftedAsString))
            {
                MessageBox.Show("Weight lifted is invalid");
                Application.Exit(); //terminate in case of invalid input
                return;
            }

            //convert to numbers
            var athleteWeight = Convert.ToDouble(athleteWeightAsString);
            var weightLifted = Convert.ToDouble(weightLiftedAsString);

            //get the coefficient
            double coefficient;
            if (athleteWeight <= 50)
                coefficient = 1.32435;
            else if (athleteWeight < 60)
                coefficient = 1.00990;
            else if (athleteWeight < 70)
                coefficient = 0.83285;
            else if (athleteWeight < 80)
                coefficient = 0.72625;
            else
                coefficient = 0.657800;

            //calculate
            var weightAdjusted = weightLifted * coefficient;

            MessageBox.Show($"Adjusted weight is: {weightAdjusted:N4}kg");
        }

        private bool IsWeightValid(string input)
        {
            //should be a positive number
            double weight;
            return double.TryParse(input, out weight) && weight > 0;
        }
    }
}
