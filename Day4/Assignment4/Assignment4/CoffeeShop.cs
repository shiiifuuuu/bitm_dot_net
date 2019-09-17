using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private List<String> customerName = new List<String> { };
        private List<String> contactNo = new List<String> { };
        private List<String> address = new List<String> { };
        private List<String> order = new List<String> { };
        private List<String> quantity = new List<String> { };
        private List<double> totalPrice = new List<double> { };

        private String message = "";
        private double price = 0;
        private int customerNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void GetData()
        {
            if(orderComboBox.Text != "")
            {
                if(quantityTextBox.Text != "")
                {
                    if (!contactNo.Contains(contactNoTextBox.Text))
                    {
                        customerName.Add(customerNameTextBox.Text);
                        contactNo.Add(contactNoTextBox.Text);
                        address.Add(addressTextBox.Text);
                        order.Add(orderComboBox.Text);
                        quantity.Add(quantityTextBox.Text);

                        double price = calculatePrice();
                        totalPrice.Add(price);

                        SetData();
                    }
                    else
                    {
                        MessageBox.Show("Contact Number already exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Select quantity of your order!");
                }
            }
            else
            {
                MessageBox.Show("Order can not be empty!!");
            }
        }

        private double calculatePrice()
        {
            switch (orderComboBox.Text)
            {
                case "Black":
                    price = int.Parse(quantityTextBox.Text) * 120;
                    break;
                case "Cold":
                    price = int.Parse(quantityTextBox.Text) * 100;
                    break;
                case "Hot":
                    price = int.Parse(quantityTextBox.Text) * 90;
                    break;
                case "Regular":
                    price = int.Parse(quantityTextBox.Text) * 80;
                    break;
            }
            return price;
        }

        private void SetData()
        {
            message = "Customer Number: " + customerNumber +
                    "\nName: " + customerNameTextBox.Text +
                    "\nContact No: " + contactNoTextBox.Text +
                    "\nAddress: " + addressTextBox.Text +
                    "\nOrder: " + orderComboBox.Text +
                    "\nQuantity: " + quantityTextBox.Text +
                    "\nTotal Price: " + price;

            showInformationRichTextBox.Text = message;
            customerNumber++;
            ClearInputs();
        }

        private void ClearInputs()
        {
            customerNameTextBox.Text = "";
            contactNoTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void ShowAllData()
        {
            showInformationRichTextBox.Text = "";
            message = "";

            for (int i=0; i<order.Count; i++)
            {
                message +=
                "Customer No: " + (i + 1) +
                    "\nName: " + customerName[i] +
                    "\nContact No: " + contactNo[i] +
                    "\nAddress: " + address[i] +
                    "\nOrder: " + order[i] +
                    "\nQuantity: " + quantity[i] +
                    "\nTotal Price: " + totalPrice[i] +
                    "\n-----------------------------\n";
            }
            showInformationRichTextBox.Text = message;
        }
    }
}
