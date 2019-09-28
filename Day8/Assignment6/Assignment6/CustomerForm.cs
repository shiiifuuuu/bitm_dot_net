using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class CustomerForm : Form
    {
        private SqlConnection sqlConnection;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void AddCustomer()
        {
            try
            {
                String name = customerNameTextBox.Text;
                String contact = contactTextBox.Text;
                String address = addressTextBox.Text;

                if (!(name == "" || contact == ""))
                {
                    String commandString = @"INSERT INTO
                                            Customers (CustomerName, Contact, Address)
                                            VALUES
                                            ('"+name+"', '"+contact+"', '"+address+"')";

                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Customer Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Customer was not added");
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Both name and contact must be inserted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }
        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void UpdateCustomer()
        {
            try
            {
                String name = updateNameTextBox.Text;
                String contact = updateContactTextBox.Text;
                String address = updateAddressTextBox.Text;
                String ID = updateIdTextBox.Text;

                if (!(name == "" || contact == "" || ID == ""))
                {
                    String commandString = @"UPDATE Customers
                                            SET
                                            CustomerName = '" + name + "', " +
                                            "Contact = " + contact + ", " +
                                            "Address = " + address + " " +
                                            "WHERE ID = " + ID + "";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Customer Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Customer could not be updated");
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Name, contact and ID must be inserted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }

        private void updateContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        private void updateIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }
        private void SearchCustomer()
        {
            if (!searchCustomerTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"SELECT * FROM Customers
                                            WHERE CustomerName LIKE '" + searchCustomerTextBox.Text + "%'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        showDataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        showDataGridView.DataSource = null;
                        MessageBox.Show("No Customer Found!");
                    }

                    sqlConnection.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Insert customer name for Searching");
            }
        }
        private void searchCustomerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }
        private void DeleteCustomer()
        {
            if (!deleteCustomerTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"DELETE FROM Customers
                                         WHERE ID='" + deleteCustomerTextBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();

                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Customer Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! There was a problem on customer deletion ");
                    }

                    sqlConnection.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Insert ID number to delete");
            }
        }
        private void deleteCustomerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                String commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found!");
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void TextInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only alphabetic characters");
            }
        }
        private void NumberInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers...");
            }
        }
        private void FloatInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("input valid gpa");
            }
        }

    }
}
