using System;
using System.Windows.Forms;

namespace CruelGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbnLess21.Checked)
                MessageBox.Show("You're too young");
            else if (rbn21to35.Checked)
                MessageBox.Show("Let's rock!");
            else
                MessageBox.Show("You're too old, grandpa");

            Application.Exit();
        }
    }
}
