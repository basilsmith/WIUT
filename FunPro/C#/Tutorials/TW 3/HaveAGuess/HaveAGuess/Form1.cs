using System;
using System.Windows.Forms;

namespace HaveAGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int myNumber;

        private void Form1_Load(object sender, EventArgs e)
        {
            var r = new Random();
            myNumber = r.Next(100);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            var usersGuess = (int) nudGuess.Value;
            if (myNumber > usersGuess)
                MessageBox.Show("My number is more");
            else if (myNumber < usersGuess)
                MessageBox.Show("My number is less");
            else
                MessageBox.Show("You're right!");
        }
    }
}
