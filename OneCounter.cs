using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneCounter
{
    public partial class OneCounter : Form
    {
        const char one = '1';

        public OneCounter()
        {
            InitializeComponent();
        }

        private void OneCounter_Load(object sender, EventArgs e)
        {
           
        }


        private void OnEnterButtonClicked(object sender, EventArgs e)
        {
            try
            {
                long from = Int64.Parse(inputFromTextBox.Text);
                long to = Int64.Parse(inputToTextBox.Text);
                int amountOfOnes = 0;
                for (long i = from; i <= to; i++)
                {
                    string currentNumber = i.ToString();
                    amountOfOnes += currentNumber.Count(digit => (digit == one));
                }
                MessageBox.Show("\t" + amountOfOnes.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert a valid number");
            }


        }
    }
}
