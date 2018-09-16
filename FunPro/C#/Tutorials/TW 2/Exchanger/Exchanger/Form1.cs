using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToDouble(tbxAmount.Text);
            var rate = Convert.ToDouble(tbxRate.Text);

            var result = amount / rate;
            
            //round the result to have two decimal places
            result = Math.Round(result, 2);

            //round the result to the nearest hundred
            result = Math.Round(result / 100) * 100;

            MessageBox.Show(result.ToString());
        }
    }
}
