using Assignment6.MANAGER;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class OrderForm : Form
    {
        private OrderManager _orderManager = new OrderManager();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String itemName = orderItemNameTextBox.Text;
            String itemQuantity = orderItemQuantityTextBox.Text;
            String itemPrice = itemPriceTextBox.Text;
            if (String.IsNullOrEmpty(itemName) || String.IsNullOrEmpty(itemQuantity))
            {
                MessageBox.Show("Both item name, quantity and item price must be inserted!");
                return;
            }
            if (_orderManager.AddOrder(itemName, itemQuantity, itemPrice))
            {
                MessageBox.Show("Order Added Successfully!");
            }
            else
            {
                MessageBox.Show("Error! Order was not placed");
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            String itemName = updateItemNameTextBox.Text;
            String itemPrice = updateItemPriceTextBox.Text;
            String itemQuantity = updateItemQuantityTextBox.Text;
            String itemId = updateItemIdTextBox.Text;

            if (String.IsNullOrEmpty(itemName) || String.IsNullOrEmpty(itemPrice) || String.IsNullOrEmpty(itemQuantity) || String.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Order name, price, quantity and ID must be inserted!");
                return;
            }

            if (_orderManager.UpdateOrder(itemName, itemPrice, itemQuantity, itemId))
            {
                MessageBox.Show("Order Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error! Order could not be updated");
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            String orderName = searchOrderTextBox.Text;
            if (String.IsNullOrEmpty(orderName))
            {
                MessageBox.Show("Insert order name to Search!!");
                return;
            }

            DataTable dataTable = _orderManager.SearchOrder(orderName);

            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                showDataGridView.DataSource = null;
                MessageBox.Show("No Order Found!");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            String orderId = deleteOrderTextBox.Text;
            if (String.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Insert ID number to delete order");
            }

            if (_orderManager.DeleteOrder(orderId))
            {
                MessageBox.Show("Order Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error! There was a problem on order deletion ");
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = _orderManager.ShowData();
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                showDataGridView.DataSource = null;
                MessageBox.Show("No Order Found!");
            }
        }



        private void orderItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Item Name can only contain alphabetic characters!");
            }
        }
        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price must be numeric!");
            }
        }
        private void orderItemQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Quantity can only be numbers");
            }
        }
        private void updateItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Item Name can only contain alphabetic characters!");
            }
        }
        private void updateItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price must be numeric!");
            }
        }
        private void updateItemQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Quantity must be numeric");
            }
        }
        private void updateItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Id must be numeric");
            }
        }
        private void searchOrderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Order Name can only contain alphabetic characters!");
            }
        }
        private void deleteOrderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Id must be numeric");
            }
        }



        private bool TextInput(KeyPressEventArgs e)
        {
            bool isLetter = false;
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr != 8 && !Char.IsWhiteSpace(chr))
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
        private bool FloatInput(KeyPressEventArgs e)
        {
            bool isFloat = false;
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
            else
            {
                isFloat = true;
            }
            return isFloat;
        }
    }
}
