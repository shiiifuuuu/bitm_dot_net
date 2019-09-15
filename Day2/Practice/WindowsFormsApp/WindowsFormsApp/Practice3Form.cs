using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Practice3Form : Form
    {
        double firstNumber, secondNumber;
        public Practice3Form()
        {
            InitializeComponent();
        }

        private void init()
        {
            firstNumber = 0;
            secondNumber = 0;
            firstNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumberTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            init();
            double result = firstNumber + secondNumber;
            resultTextBox.Text = result + "";
        }
    }
}
