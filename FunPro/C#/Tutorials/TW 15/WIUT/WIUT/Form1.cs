using System;
using System.Windows.Forms;

namespace WIUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bis = new Course("BIS");
            var applicant = new Applicant("Anna", 
                "Kozlova", 
                "T. Malik 100/15", 
                new DateTime(1995, 4, 10), 
                "Single", 
                "AA 123456", 
                bis);
            MessageBox.Show($"{applicant.Name} is on {applicant.Course.Name}");
        }
    }
}
