using System;
using System.Windows.Forms;

namespace TextAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var str = tbxInput.Text;
            var noOfWords = 1;
            var noOfVowels = 0;
            var noOfConsonants = 0;

            //remove leading and trailing spaces
            str = str.Trim();
            
            //special case - if nothing is entered
            if (str == "")
                noOfWords = 0;

            //no need to check both upper and lower cases
            str = str.ToUpper();

            //handle new line and tab chars
            str = str.Replace("\n", " ").Replace("\r", " ").Replace("\t", " ");

            //handle extra spaces inside
            //check if we have any "  " left inside
            while (str.Contains("  "))
                str = str.Replace("  ", " ");

            //check the content
            foreach (var c in str)
            {
                switch (c)
                {
                    case ' ':
                        noOfWords++;
                        break;
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        noOfVowels++;
                        break;
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        noOfConsonants++;
                        break;
                }
            }

            //average number of chars per word
            //need to know total number of non-space characters
            var totalNumberOfNonSpaceChars = str.Replace(" ", "").Length;
            //need to cast to double to avoid integer division
            var averageNumberOfCharsPerWord = totalNumberOfNonSpaceChars / (double)noOfWords; 

            var message = $@"
Number of words: {noOfWords}
Number of vowels: {noOfVowels}
Number of consonants: {noOfConsonants}
Letters per word: {averageNumberOfCharsPerWord:N2}";
            MessageBox.Show(message);
        }
    }
}
