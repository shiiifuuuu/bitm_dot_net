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
    public partial class OrderForm : Form
    {
        private SqlConnection sqlConnection;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrder();
        }
        private void AddOrder()
        {
            try
            {
                String itemName = orderItemNameTextBox.Text;
                String itemQuantity = orderItemQuantityTextBox.Text;
                String itemPrice = itemPriceTextBox.Text;

                float totalPrice = float.Parse(itemPrice) * int.Parse(itemQuantity);

                if (!(itemName == "" || itemQuantity == ""))
                {
                    String commandString = @"INSERT INTO 
	                                            Orders (OrderItem, Quantity, TotalPrice)
                                            VALUES
	                                            ('" + itemName + "', " + itemQuantity + ", "+totalPrice+")";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Order Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Order was not placed");
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Both item name, quantity and item price must be inserted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void orderItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }
        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatInput(e);
        }
        private void orderItemQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateOrder();

        }
        private void UpdateOrder()
        {
            try
            {
                String itemName = updateItemNameTextBox.Text;
                String itemPrice = updateItemPriceTextBox.Text;
                String itemQuantity = updateItemQuantityTextBox.Text;
                String itemID = updateItemIdTextBox.Text;

                float totalPrice = float.Parse(itemPrice) * int.Parse(itemQuantity);

                if (!(itemName == "" || itemPrice == "" || itemQuantity == "" || itemID == ""))
                {
                    String commandString = @"UPDATE Orders
                                            SET
                                            OrderItem = '" + itemName + "', " +
                                            "Quantity = " + itemQuantity + ", " +
                                            "TotalPrice = " + totalPrice + " " +
                                            "WHERE ID = " + itemID + "";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Order Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Order could not be updated");
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Order name, price, quantity and ID must be inserted!");
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
        private void updateItemQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }
        private void updateItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchOrder();
        }
        private void SearchOrder()
        {
            if (!searchOrderTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"SELECT * FROM Orders
                                            WHERE OrderItem LIKE '" + searchOrderTextBox.Text + "%'";
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
                        MessageBox.Show("No Order Found!");
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
                MessageBox.Show("Insert item name to Search order");
            }
        }
        private void searchOrderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }
        private void DeleteOrder()
        {
            if (!deleteOrderTextBox.Text.Equals(""))
            {
                try
                {
                    String commandString = @"DELETE FROM Orders
                                         WHERE ID='" + deleteOrderTextBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();

                    int queryCheck = sqlCommand.ExecuteNonQuery();
                    if (queryCheck > 0)
                    {
                        MessageBox.Show("Order Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! There was a problem on order deletion ");
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
                MessageBox.Show("Insert ID number to delete order");
            }

        }
        private void deleteOrderTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                String commandString = @"SELECT * FROM Orders";
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
