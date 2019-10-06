using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LT2.MODEL;
using LT2.MANAGER;

namespace LT2
{
    public partial class SearchByImeiForm : Form
    {
        private Mobile _mobile = new Mobile();
        private MobileManager _mobileManager = new MobileManager();

        public SearchByImeiForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                String searchText = searchImeiTextBox.Text;
                if (String.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Insert imei number for Searching");
                    return;
                }
                if (searchImeiTextBox.Text.Length < 15)
                {
                    MessageBox.Show("IMEI requires exact 15 characters!");
                    return;
                }

                _mobile = _mobileManager.SearchMobileByImei(searchText);
                if (!String.IsNullOrEmpty(_mobile.IMEI))
                {
                    MessageBox.Show("Mobile handset found!");
                    modelNameLabel.Text = _mobile.ModelName;
                    imeiLabel.Text = _mobile.IMEI;
                    priceLabel.Text = _mobile.Price;
                }
                else
                {
                    MessageBox.Show("Mobile not found!!");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _mobileManager.CloseConnection();
            }
        }

        private void searchImeiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("IMEI can not contains letters!");
            }
            if ((searchImeiTextBox.Text.Length == 15) && (e.KeyChar != 8))
            {
                MessageBox.Show("IMEI length can not excced 15 characters!");
                searchImeiTextBox.MaxLength = 15;
            }
        }
        public bool DigitInput(KeyPressEventArgs e)
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
    }
}
