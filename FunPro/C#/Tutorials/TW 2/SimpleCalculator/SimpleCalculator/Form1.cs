using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = number1 + number2;

            lblResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = number1 - number2;

            lblResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = number1 / number2;

            lblResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = number1 * number2;

            lblResult.Text = result.ToString();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = number1 % number2;

            lblResult.Text = result.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(tbxNumber1.Text);
            var number2 = Convert.ToDouble(tbxNumber2.Text);
            var result = Math.Pow(number1, number2);

            lblResult.Text = result.ToString();
        }
    }
}
