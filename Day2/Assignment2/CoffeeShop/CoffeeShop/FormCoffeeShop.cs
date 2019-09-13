using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class FormCoffeeShop : Form
    {
        public FormCoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String name = customerNameTextBox.Text;
            String contact = contactTextBox.Text;
            String address = addressTextBox.Text;
            String order = orderComboBox.Text;
            String quantity = quantityTextBox.Text;
            double totalPrice = 0;

            if (quantity != "")
            {
                switch (order)
                {
                    case "Black - 120":
                        totalPrice = int.Parse(quantity) * 120;
                        break;
                    case "Cold - 100":
                        totalPrice = int.Parse(quantity) * 100;
                        break;
                    case "Hot - 90":
                        totalPrice = int.Parse(quantity) * 90;
                        break;
                    case "Regular - 80":
                        totalPrice = int.Parse(quantity) * 80;
                        break;
                }


                if (order != "")
                {
                    showInformationRichTextBox.Text = "Customer Name: " + name + "\nContact No: " + contact
                    + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity
                    + "\n\n\nTotal Price: " + totalPrice + " bdt";

                    MessageBox.Show("Order completed successfully.");
                }
                else
                {
                    MessageBox.Show("Please Select an order item..");
                }
            }
            else
            {
                MessageBox.Show("Please select quantity!");
            }

        }
    }
}
