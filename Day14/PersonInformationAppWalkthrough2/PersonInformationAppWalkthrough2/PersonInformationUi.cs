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


        Person aPerson;

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string fullName = aPerson.GetFullName();
            fullNameTextBox.Text = fullName;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aPerson = new Person(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text);
            //string fullName = aPerson.GetFullName();
            //fullNameTextBox.Text = fullName;
            //aPerson.FirstName = firstNameTextBox.Text;
            // aPerson.MiddleName = middleNameTextBox.Text;
            // aPerson.LastName = lastNameTextBox.Text;

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void PersonInformationUi_Load(object sender, EventArgs e)
        {

        }
    }
}
