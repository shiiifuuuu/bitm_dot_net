using Assignment6.MANAGER;
using System;
using System.Windows.Forms;
using Assignment6.MODEL;

namespace Assignment6
{
    public partial class ItemForm : Form
    {
        private Item _item = new Item();
        private ItemManager _itemManager = new ItemManager();

        public ItemForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _item.Name = addItemNameTextBox.Text;
            _item.Price = addItemPriceTextBox.Text;

            if (String.IsNullOrEmpty(_item.Name) || String.IsNullOrEmpty(_item.Price))
            {
                MessageBox.Show("Both name and price must be inserted!");
                return;
            }
            if (_itemManager.IsItemExist(_item))
            {
                MessageBox.Show("Item " + _item.Name + " already exists in your database!");
                return;
            }

            if (_itemManager.AddItem(_item))
            {
                MessageBox.Show("Item " + addItemNameTextBox.Text + " added Successfully!");
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            _item.Name = updateItemNameTextBox.Text;
            _item.Price = updateItemPriceTextBox.Text;
            _item.ID = updateItemIdTextBox.Text;

            if (String.IsNullOrEmpty(_item.Name) || String.IsNullOrEmpty(_item.Price) || String.IsNullOrEmpty(_item.ID))
            {
                MessageBox.Show("Item name, price and ID must be inserted!");
                return;
            }

            if (_itemManager.UpdateItem(_item))
            {
                MessageBox.Show("Item Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error! Item could not be updated");
            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            _item.ID = deleteItemIdTextBox.Text;

            if (String.IsNullOrEmpty(_item.ID))
            {
                MessageBox.Show("Insert ID number to delete item");
                return;
            }

            if (_itemManager.DeleteItem(_item))
            {
                MessageBox.Show("Item Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error! There was a problem on item deletion ");
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            _item.Name = searchItemTextBox.Text;
            if (String.IsNullOrEmpty(_item.Name))
            {
                MessageBox.Show("Insert item name for Searching");
                return;
            }

            if (_itemManager.SearchItem(_item).Rows.Count > 0)
            {
                showDataGridView.DataSource = _itemManager.SearchItem(_item);
            }
            else
            {
                showDataGridView.DataSource = null;
                MessageBox.Show("No Data Found!");
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            if (_itemManager.ShowData().Rows.Count > 0)
            {
                showDataGridView.DataSource = _itemManager.ShowData();
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }

        }


        private void addItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Item name must contain alphabetic characters!");
            }
        }
        private void addItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price contains only numeric value!");
            }
        }
        private void updateItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Item name must contain alphabetic characters!");
            }
        }
        private void updateItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price contains only numeric value!");
            }
        }
        private void updateItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Id contains only numeric value!");
            }
        }
        private void deleteItemIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("Id contains only numeric value!");
            }
        }
        private void searchItemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextInput(e))
            {
                MessageBox.Show("Item name must contain alphabetic characters!");
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
