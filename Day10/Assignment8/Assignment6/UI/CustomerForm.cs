using Assignment6.MANAGER;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment6.UI
{
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager = new CustomerManager();

        public CustomerForm()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            String name = customerNameTextBox.Text;
            String contact = contactTextBox.Text;
            String address = addressTextBox.Text;

            if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Both name and contact must be inserted!");
                return;
            }
            if (_customerManager.isCustomerExist(name))
            {
                MessageBox.Show("Customer " + name + " already exist in your database!");
                return;
            }

            bool customerAdded = _customerManager.AddCustomer(name, contact, address);

            if (customerAdded)
            {
                MessageBox.Show(name + " customer added Successfully.");
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            String name = searchCustomerTextBox.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Insert customer name for Searching");
                return;
            }
            DataTable dataTable = _customerManager.SearchCustomer(name);
            if (dataTable != null)
            {
                MessageBox.Show("Customer Found!");
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Customer Found!");
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            String name = updateNameTextBox.Text;
            String contact = updateContactTextBox.Text;
            String address = updateAddressTextBox.Text;
            String id = updateIdTextBox.Text;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(contact) || String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Name, contact and ID must be inserted!");
                return;
            }

            bool customerUpdated = _customerManager.UpdateCustomer(name, contact, address, id);

            if (customerUpdated)
            {
                MessageBox.Show("Customer Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error! Customer could not be updated");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            String id = deleteCustomerTextBox.Text;
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Insert ID number to delete");
            }
            bool customerDeleted = _customerManager.DeleteCustomer(id);
            if (customerDeleted)
            {
                MessageBox.Show("Customer Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error! There was a problem on customer deletion ");
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = _customerManager.ShowData();
            if (dataTable == null)
            {
                MessageBox.Show("No Data Found!");
                return;
            }
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
        }



        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Customer Name can only contain alphabetic characters!");
            }
        }
        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = DigitInput(e);
            if (!isDigit)
            {
                MessageBox.Show("Contact can only contain Digits!");
            }

            if (contactTextBox.Text.Length > 11)
            {
                MessageBox.Show("Contact length can not exceed 11 digits!");
                contactTextBox.MaxLength = 11;
            }
        }
        private void updateNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isLetter = TextInput(e);
            if (!isLetter)
            {
                MessageBox.Show("Customer Name can only contain alphabetic characters!");
            }
        }
        private void updateContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = DigitInput(e);
            if (!isDigit)
            {
                MessageBox.Show("Contact can only contain Digits!");
            }

            if (contactTextBox.Text.Length > 11)
            {
                MessageBox.Show("Contact length can not exceed 11 digits!");
                contactTextBox.MaxLength = 11;
            }
        }
        private void updateIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = DigitInput(e);
            if (!isNumber)
            {
                MessageBox.Show("ID can only contain Digits!");
            }
        }
        private void searchCustomerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isLetter = TextInput(e);
            if (!isLetter)
            {
                MessageBox.Show("Name can contain Letters only!");
            }
        }
        private void deleteCustomerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = DigitInput(e);
            if (!isNumber)
            {
                MessageBox.Show("Delete customer by ID number!");
            }
        }



        private bool TextInput(KeyPressEventArgs e)
        {
            bool isLetter = false;
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr!=8 && !Char.IsWhiteSpace(chr))
            {
                e.Handled = true;
            }
            else
            {
                isLetter = true;
            }
            return isLetter;
        }
        private bool DigitInput(KeyPressEventArgs e)
        {
            bool isDigit = false;
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
            else
            {
                isDigit = true;
            }
            return isDigit;
        }
    }
}
