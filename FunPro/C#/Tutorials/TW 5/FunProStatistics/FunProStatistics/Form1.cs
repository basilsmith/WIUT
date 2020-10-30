using System;
using System.Windows.Forms;

namespace FunProStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //grab user input
            var marks = tbxInput.Text.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //variable to hold the statistics
            var noOfMarksLess30 = 0;
            var noOfMarks30To40 = 0;
            var noOfMarks40To50 = 0;
            var noOfMarks50To60 = 0;
            var noOfMarks60To70 = 0;
            var noOfMarksMore70 = 0;

            //processing each mark
            foreach (var element in marks)
            {
                var mark = Convert.ToInt32(element);
                if (mark < 30)
                    noOfMarksLess30++;
                else if (mark < 40)
                    noOfMarks30To40++;
                else if (mark < 50)
                    noOfMarks40To50++;
                else if (mark < 60)
                    noOfMarks50To60++;
                else if (mark < 70)
                    noOfMarks60To70++;
                else
                    noOfMarksMore70++;
            }

            var message = 
$@"
30+: {noOfMarksLess30}
30-40: {noOfMarks30To40}
40-50: {noOfMarks40To50}
50-60: {noOfMarks50To60}
60-70: {noOfMarks60To70}
70+: {noOfMarksMore70}";
            MessageBox.Show(message);

        }
    }
}
