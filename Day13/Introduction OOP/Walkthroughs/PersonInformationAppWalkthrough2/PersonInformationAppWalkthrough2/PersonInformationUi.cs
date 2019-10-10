using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        public PersonInformationUi()
        {
            InitializeComponent();
        }


        Person aPerson = new Person();

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string fullName = aPerson.GetFullName();
            fullNameTextBox.Text = fullName;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
             aPerson.firstName = firstNameTextBox.Text;
             aPerson.middleName = middleNameTextBox.Text;
             aPerson.lastName = lastNameTextBox.Text;


            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }
    }
}
