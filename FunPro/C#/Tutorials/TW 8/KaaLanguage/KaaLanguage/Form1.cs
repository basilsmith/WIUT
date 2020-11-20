using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaaLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text;
            
            //validating input
            if (input == "")
            {
                MessageBox.Show("Invalid input");
                Application.Exit(); //should terminate in case of invalid input
            }

            //adding "kaa" after all vowels
            //replacing "a" with "akaa" must be first to avoid replacing "a"s inside "kaa"
            input = input.Replace("a", "akaa");
            input = input.Replace("e", "ekaa");
            input = input.Replace("i", "ikaa");
            input = input.Replace("o", "okaa");
            input = input.Replace("u", "ukaa");

            //same for upper case
            input = input.Replace("A", "Akaa");
            input = input.Replace("E", "Ekaa");
            input = input.Replace("I", "Ikaa");
            input = input.Replace("O", "Okaa");
            input = input.Replace("U", "Ukaa");

            //ready to show the output
            MessageBox.Show(input);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text;

            //validating input
            if (input == "")
            {
                MessageBox.Show("Invalid input");
                Application.Exit(); //should terminate in case of invalid input
                return;
            }

            //just need to remove all "kaa"s
            input = input.Replace("kaa", "");

            //ready to show the output
            MessageBox.Show(input);
        }
    }
}
