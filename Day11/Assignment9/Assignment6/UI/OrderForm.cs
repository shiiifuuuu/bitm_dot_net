using Assignment6.MANAGER;
using System;
using System.Data;
using System.Windows.Forms;
using Assignment6.MODEL;

namespace Assignment6
{
    public partial class OrderForm : Form
    {
        private OrderManager _orderManager = new OrderManager();
        private Order _order = new Order();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            addCustomerComboBox.DataSource = _orderManager.CustomerComboShow();
            addItemComboBox.DataSource = _orderManager.ItemComboShow();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _order.CustomerId = addCustomerComboBox.SelectedValue.ToString();  
            _order.ItemId = addItemComboBox.SelectedValue.ToString();
            _order.Quantity = orderItemQuantityTextBox.Text;

            if (String.IsNullOrEmpty(_order.Quantity))
            {
                MessageBox.Show("Quantity can not be empty!");
                return;
            }
            if (_orderManager.AddOrder(_order))
            {
                totalPriceTextBox.Text = _order.Price;
                MessageBox.Show("Order Added Successfully!");
            }
            else
            {
                MessageBox.Show("Error! Order was not placed");
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            _order.CustomerId = updateCustomerComboBox.SelectedValue.ToString();
            _order.ItemId = updateItemComboBox.SelectedValue.ToString();
            _order.Quantity = updateItemQuantityTextBox.Text;

            if (String.IsNullOrEmpty(_order.Quantity))
            {
                MessageBox.Show("Order quantity can not be empty!");
                return;
            }

            if (_orderManager.UpdateOrder(_order))
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
            String searchText = searchOrderTextBox.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Search box is empty!!");
                return;
            }

            DataTable dataTable = _orderManager.SearchOrder(searchText);

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
            _order.Id = deleteOrderTextBox.Text;
            if (String.IsNullOrEmpty(_order.Id))
            {
                MessageBox.Show("Insert ID number to delete order");
            }

            if (_orderManager.DeleteOrder(_order))
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
            //if (!textinput(e))
            //{
            //    messagebox.show("order name can only contain alphabetic characters!");
            //}
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

        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateCustomerComboBox.DataSource = _orderManager.CustomerComboShow();
            updateItemComboBox.DataSource = _orderManager.ItemComboShow();

            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showDataGridView.CurrentRow.Selected = true;
                updateCustomerComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
                updateItemComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                updateItemQuantityTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

                _order.Id = showDataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            }
        }
    }
}
