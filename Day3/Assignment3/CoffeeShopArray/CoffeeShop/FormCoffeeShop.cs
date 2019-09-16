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
        private const int SIZE = 3;
        private int customerNumber = 0;

        private String[] name = new String[SIZE];
        private String[] contact = new String[SIZE];
        private String[] address = new String[SIZE];
        private String[] order = new String[SIZE];
        private String[] quantity = new String[SIZE];

        private double totalPrice;
        private String[] savedData = new String[SIZE];


        public FormCoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (customerNumber == SIZE)
            {
                MessageBox.Show("Complete!");
            }
            else
            {
                getData();

                if (order[customerNumber] != "")
                {
                    if (quantity[customerNumber] != "")
                    {
                        setData();
                    }
                    else
                    {
                        MessageBox.Show("Please select quantity!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select an order item..");
                }
            }
            

        }

        private void getData()
        {
            totalPrice = 0;
            name[customerNumber] = customerNameTextBox.Text;
            contact[customerNumber] = contactTextBox.Text;
            address[customerNumber] = addressTextBox.Text;
            order[customerNumber] = orderComboBox.Text;
            quantity[customerNumber] = quantityTextBox.Text;
        }

        private void setData()
        {
            switch (order[customerNumber])
            {
                case "Black":
                    totalPrice = int.Parse(quantity[customerNumber]) * 120;
                    break;
                case "Cold":
                    totalPrice = int.Parse(quantity[customerNumber]) * 100;
                    break;
                case "Hot":
                    totalPrice = int.Parse(quantity[customerNumber]) * 90;
                    break;
                case "Regular":
                    totalPrice = int.Parse(quantity[customerNumber]) * 80;
                    break;
            }


            savedData[customerNumber] = "Customer No: " + (customerNumber + 1) +
                "\nCustomer Name: " + name[customerNumber] +
                "\nContact No: " + contact[customerNumber] +
                "\nAddress: " + address[customerNumber] +
                "\nOrder: " + order[customerNumber] +
                "\nQuantity: " + quantity[customerNumber] +
                "\nTotal Price: " + totalPrice + " bdt" +
                "\n------------------------------------";

            showInformationRichTextBox.Text += savedData[customerNumber] + "\n\n";

            customerNumber++;
            emptyTextBox();
        }

        private void emptyTextBox()
        {
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }
    }
}
