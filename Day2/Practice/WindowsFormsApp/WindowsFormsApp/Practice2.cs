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
    public partial class Practice2Form : Form
    {

        String firstName;
        String lastName;
        String fathersName;
        String mothersName;
        String address;

        public Practice2Form()
        {
            InitializeComponent();
        }

        private void init()
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            init();
            MessageBox.Show("Information Saved");
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + firstName + "\nLast Name: " + lastName +
                "\nFather's Name: " + fathersName + "\nMother's Name: " + mothersName +
                "\nAddress: " + address);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + firstName + " " + lastName);
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name: " + fathersName + "\nMother's Name: " + mothersName);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address: " + address);
        }
    }
}
