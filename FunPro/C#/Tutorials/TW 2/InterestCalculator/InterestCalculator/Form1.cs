using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;
            var amount = nudAmount.Value;
            var rate = nudRate.Value;

            var interest = amount * rate / 100;

            var result = amount + interest;

            string message = "";
            message += "Name: " + name;
            message += "\n";
            message += "Amount: " + amount;
            message += "\n";
            message += "Rate: " + rate;
            message += "\n";
            message += "Balance: " + result;
            MessageBox.Show(message);
        }
    }
}
