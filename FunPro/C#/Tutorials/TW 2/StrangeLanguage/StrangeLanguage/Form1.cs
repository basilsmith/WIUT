using System;
using System.Windows.Forms;

namespace StrangeLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            //translation rules
            //wo|rk => rk|wo
            //stu|dent => dent|stu

            var input = tbxInput.Text;
            var length = input.Length;

            //NOTE: in C# dividing integer over integer results in another integer
            //thus 3 / 2 is equal to 1, not to 1.5 or 2
            //use 3.0 / 2 or 3 / 2.0 to get 1.5
            //uncomment the following lines to explore
            //MessageBox.Show((3 / 2).ToString()); //shows 1
            //MessageBox.Show((3.0 / 2).ToString()); //shows 1.5
            //MessageBox.Show((3 / 2.0).ToString()); //shows 1.5

            //back to topic
            var lengthOfFirstPart = length / 2;
            var firstPart = input.Substring(0, lengthOfFirstPart);
            var secondPart = input.Substring(lengthOfFirstPart);
            var result = secondPart + firstPart;
            MessageBox.Show(result);
        }
    }
}
