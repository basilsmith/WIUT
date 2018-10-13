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
           
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Sorting");
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }
    }
}
