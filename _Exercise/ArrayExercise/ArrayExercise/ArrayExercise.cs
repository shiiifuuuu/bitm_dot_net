using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExercise
{
    public partial class ArrayExercise : Form
    {

        const int size = 2;
        int userSize = 0;
        int count = 0;
        int length;
        String[] elements = new String[size];

        public ArrayExercise()
        {
            InitializeComponent();
            length = elements.Length;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(userSize != 0)
            {
                addElements(userSize);
            }
            else
            {
                addElements(size);
            }
        }

        private void addElements(int size)
        {
            if (count != size)
            {
                elements[count] = addTextBox.Text;
                addTextBox.Text = "";
                count++;
                if((length-1) == 0)
                {
                    MessageBox.Show("No more elements to add");
                }
                else
                {
                    MessageBox.Show("Add " + (length - 1) + " more elements");
                }
                length--;
            }
            else
            {
                MessageBox.Show("Size Exceed!!! Input your size to show more elements.");
                addTextBox.Text = "";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showElementsRichTextBox.Text = "Elements in array are: " + showElementsFromArray(elements);
        }

        private String showElementsFromArray(String[] array)
        {
            String message = "";
            for (int i = 0; i < array.Length; i++)
            {
                message += array[i] + " ";
            }
            return message;
        }

        private void addSizeButton_Click(object sender, EventArgs e)
        {
            userSize = int.Parse(arraySizeTextBox.Text);
            arraySizeTextBox.Text = "";
            elements = new String[userSize];
            length = elements.Length;
            count = 0;
            sizeLabel.Text = "Input " + userSize + " elements in the array.";
        }


        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i=0; i<elements.Length; i++)
            {
                sum += int.Parse(elements[i]);
            }
            showElementsRichTextBox.Text = "Sum of all elemetns stored in array: " + sum;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            String[] newArray = new String[elements.Length];
            elements.CopyTo(newArray, 0);
            String array1 = showElementsFromArray(elements);
            String array2 = showElementsFromArray(newArray);

            showElementsRichTextBox.Text = "The elements stored in first Array: " + array1 
                                            + "\n\n" 
                                            + "The elements stored in second Array: " + array2;
        }
    }
}
