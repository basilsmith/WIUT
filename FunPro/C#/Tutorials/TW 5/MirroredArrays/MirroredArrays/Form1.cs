using System;
using System.Windows.Forms;

namespace MirroredArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //grab user input
            var a = tbxInput.Text.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //create another array of the same size
            var b = new string[a.Length];
            
            //processing
            for(var i = 0; i < a.Length; i++)
            {
                b[a.Length - i - 1] = a[i];
            }

            //showing result
            var message = "";
            for (var i = 0; i < a.Length; i++)
            {
                message += a[i] + " => " + b[i] + "\n";
            }
            MessageBox.Show(message);   
        }
    }
}
