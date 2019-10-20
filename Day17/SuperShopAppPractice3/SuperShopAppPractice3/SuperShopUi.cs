using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        private Shop _shop;

        public SuperShopUi()
        {
            InitializeComponent();
        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            _shop = new Shop();
            _shop.Name = nameTextBox.Text;
            _shop.Address = addressTextBox.Text;
        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            _shop.Product.Id = itemTextBox.Text;
            _shop.Product.Quantity = int.Parse(quantityTextBox.Text);

            _shop.AddProduct(_shop.Product);
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            string message = $"Shop Name \t\t Address \t\t Item Id \t Quantity" + Environment.NewLine;
            message += _shop.GetInfo();
            MessageBox.Show(message);
        }
    }
}
