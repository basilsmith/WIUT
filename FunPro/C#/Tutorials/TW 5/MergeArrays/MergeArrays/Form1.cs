using System;
using System.Linq;
using System.Windows.Forms;

namespace MergeArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //get the data
            var a = tbxA.Text.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var b = tbxB.Text.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            var lengthOfC = a.Length + b.Length;
            var c = new string[lengthOfC];

            var currentIndex = 0; //the index to add new element to the resulting array

            //get unique elements from A
            foreach (var element in a)
            {
                //check if we alredy have the item in resulting array 
                if (!c.Contains(element))
                {
                    //not yet present - add
                    c[currentIndex] = element;

                    currentIndex++; //so that next new element will go to the next position(index)
                }
            }

            //get unique elements from B
            foreach (var element in b)
            {
                //check if we alredy have the item in resulting array 
                if (!c.Contains(element))
                {
                    //not yet present - add
                    c[currentIndex] = element;

                    currentIndex++; //so that next new element will go to the next position(index)
                }
            }

            //get rid of unused items
            Array.Resize(ref c, currentIndex);


            //sort it
            Array.Sort(c);

            var message = string.Join(", ", c);

            MessageBox.Show(message);
        }
    }
}
