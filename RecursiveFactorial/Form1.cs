using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RecursiveFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (Convert.ToInt64(inputTextBox.Text));
                BigInteger bigInt = new BigInteger(x);
                outputTextBox.Text = factorial(bigInt).ToString("N0");              
            }
            catch
            {
                MessageBox.Show("You Must enter a number into the input!");
                inputTextBox.Text = "";
            }
        }
        private BigInteger factorial(BigInteger n)
        {            
            if (n == BigInteger.One)
            {
                return 1;             
            }
            BigInteger result;
            result = factorial(n - BigInteger.One) * n;
            return result;

        }
        
    }
}
