using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListUI
{
    public partial class ListUI : Form
    {
        private List<String> names = new List<String> { };
        private List<String> ages = new List<String> { };
        private String message = "";
        public ListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
            EmptyInputs();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showAllCustomer();
        }

        private void showAllCustomer()
        {
            message = "";
            for (int i = 0; i < ages.Count; i++)
            {
                message += "Name: " + names[i] + " Age: " + ages[i] + "\n";
            }
            MessageBox.Show(message);
        }

        private void AddCustomer()
        {
            names.Add(nameTextBox.Text);
            ages.Add(ageTextBox.Text);
            showCustomer();
        }

        private void showCustomer()
        {
            message = "Name: " + nameTextBox.Text + " Age: " + ageTextBox.Text;
            MessageBox.Show(message);
        }

        private void EmptyInputs()
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
        }
    }
}
