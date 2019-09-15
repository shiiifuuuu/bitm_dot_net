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
    public partial class ExerciseForm : Form
    {
        public ExerciseForm()
        {
            InitializeComponent();
        }

        private void showExercise1Button_Click(object sender, EventArgs e)
        {
            string message = "";
            const int size = 10;
            int[] element = new int[size];
            for (int i = 0; i < size; i++)
            {
                element[i] = i;
            }
            for (int i = 0; i < size; i++)
            {
                message = message + element[i] + " ";
            }
            MessageBox.Show("Elements is array are: " + message);
        }

        int size = 0;
        String[] elements;
        int index=0;
        String result = "";

        private void showExercise2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input the number of elements to store in the array: ");
        }
        private void sizeButton_Click(object sender, EventArgs e)
        {
            size = int.Parse(inputTextBox.Text);
            elements = new String[size];
            inputTextBox.Text = "";
            MessageBox.Show("Input " + size + " numbers of elements in the array");
        }
        
        private void addElementsButton_Click(object sender, EventArgs e)
        {
            
            if (inputTextBox.Text != "")
            {
                if (size != 0)
                {
                    elements[index] = inputTextBox.Text;
                    inputTextBox.Text = "";
                    index++;
                    size--;
                    MessageBox.Show("Input " + size + " numbers of elements in the array");
                }
                else
                {
                    MessageBox.Show("Input Done");
                }
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<size; i++)
            {
                result = result + elements[i] + " ";
            }
            String msg1 = result;
            for(int i = size - 1; i > 0; i--)
            {
                result = result + elements[i] + " ";
            }String msg2 = result;
            MessageBox.Show("The value store in the array are: " + msg1
                + "The value in reverse order are: " + msg2);
        }
    }
}
