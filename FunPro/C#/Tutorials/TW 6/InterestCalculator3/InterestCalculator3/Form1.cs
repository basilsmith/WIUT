using System;
using System.Windows.Forms;

namespace InterestCalculator3
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

            var result = amount + amount * rate / 100;
            var oldMessage = String.Format("Date: {0:ddd, dd-MM-yyyy}{1}" +
                                           "Name: {2}{1}" +
                                           "Amount: {3:C2}{1}" +
                                           "Rate: {4:N1}{1}" +
                                           "Balance: {5:C2}{1}" +
                                           "Thank you!",
                                           DateTime.Now,
                                           "\n",
                                           name,
                                           amount,
                                           rate,
                                           result);

            MessageBox.Show(oldMessage);

            var newMessage =
$@"Date: {DateTime.Now:ddd, dd-MM-yyyy}
Name: {name}
Amount: {amount:C2}
Rate: {rate:N1}
Balance: {result:C2}
Thank you!";
            MessageBox.Show(newMessage);
        }
    }
}

