using System;
using System.Windows.Forms;

namespace TheSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOddNumbers_Click(object sender, EventArgs e)
        {
            long sum = 0;
            checked
            {
                for (int i = 1; i <= 1000000; i = i + 2)
                {
                    sum += i;
                }
                MessageBox.Show(sum.ToString());
            }
        }

        private void btnEvenNumbers_Click(object sender, EventArgs e)
        {
            long sum = 0;
            checked
            {
                for (int i = 2; i <= 1000000; i = i + 2)
                {
                    sum += i;
                }
                MessageBox.Show(sum.ToString());
            }
        }
    }
}
