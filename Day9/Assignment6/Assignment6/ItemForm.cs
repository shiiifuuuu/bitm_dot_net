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
    public partial class ItemForm : Form
    {
        private SqlConnection sqlConnection;

        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addItemNameTextBox.Text))
            {
                MessageBox.Show("Item name can not be empty!");
                return;
            }
            if (String.IsNullOrEmpty(addItemPriceTextBox.Text))
            {
                MessageBox.Show("Price can not be empty!");
                return;
            }
            if (isItemExist(addItemNameTextBox.Text))
            {
                MessageBox.Show(addItemNameTextBox.Text + " already exists");
                return;
            }

            bool isAdded = AddItem(addItemNameTextBox.Text, addItemPriceTextBox.Text);
            if (isAdded)
            {
                MessageBox.Show(addItemNameTextBox.Text + " added Successfully!");
            }
        }
        private bool AddItem(String name, String price)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO 
	                                    Items (ItemName, Price)
                                    VALUES
	                                    ('" + name + "', " + price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int queryCheck = sqlCommand.ExecuteNonQuery();
                if (queryCheck > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isAdded;
        }
        private void addItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }
        private void addItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatInput(e);
        }

        private bool isItemExist(String name)
        {
            bool isItemExist = false;
            try
            {
                String commandString = @"SELECT * FROM Items
                                            WHERE ItemName LIKE '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isItemExist = true;
                }

                sqlConnection.Close();
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isItemExist;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }
        private void UpdateItem()
        {
            try
            {
                String itemName = updateItemNameTextBox.Text;
                String itemPrice = updateItemPriceTextBox.Text;
                String itemID = updateItemIdTextBox.Text;

                if (!(itemName == "" || itemPrice == ""))
                {
                    String commandString = @"UPDATE ITEMS 
	                                    SET ItemName = '" + itemName + "', " +
                                            "Price =  " + itemPrice + " " +
                                            "WHERE ID = '" + itemID + "' ";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Item Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Item could not be updated");
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Item name, price and ID must be inserted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void updateItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }
        private void updateItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatInput(e);
        }
        private void updateItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
        private void DeleteItem()
        {
            if (!deleteItemIdTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"DELETE FROM Items
                                         WHERE ID='" + deleteItemIdTextBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();

                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Item Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! There was a problem on item deletion ");
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
                MessageBox.Show("Insert ID number to delete item");
            }
            
        }
        private void deleteItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchItem();
        }
        private void SearchItem()
        {
            if (!searchItemTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"SELECT * FROM Items
                                            WHERE ItemName LIKE '"+searchItemTextBox.Text+"%'";
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
                        MessageBox.Show("No Data Found!");
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
                MessageBox.Show("Insert ID number to delete item");
            }
        }
        private void searchItemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                String commandString = @"SELECT * FROM Items";
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
            }catch(Exception exception)
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
