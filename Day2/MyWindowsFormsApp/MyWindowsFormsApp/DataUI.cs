using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class DataUI : Form
    {
        public DataUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            /*int age = 0;
            double salary = 5000.50;
            String name = "Hasan";
            bool isDone = true;*/

            String name = nameTextBox.Text;

            int firstNumber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);

            int result = firstNumber + secondNumber;

            //MessageBox.Show("Name: " + name + " result = " + result.ToString());
            MessageBox.Show(result + " ");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
