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
    public partial class SaveForm : Form
    {
        private Mobile _mobile = new Mobile();
        private MobileManager _mobileManager = new MobileManager();
        public SaveForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _mobile.ModelName = modelNameTextBox.Text;
                _mobile.IMEI = imeiTextBox.Text;
                _mobile.Price = priceTextBox.Text;
                if (String.IsNullOrEmpty(_mobile.ModelName))
                {
                    MessageBox.Show("Insert Model Name!!");
                    return;
                }
                if (String.IsNullOrEmpty(_mobile.IMEI))
                {
                    MessageBox.Show("Insert IMEI!!");
                    return;
                }
                if (_mobile.IMEI.Length < 15)
                {
                    MessageBox.Show("IMEI requires exact 15 characters!");
                    return;
                }
                if (String.IsNullOrEmpty(_mobile.Price))
                {
                    MessageBox.Show("Insert Price!!");
                    return;
                }
                if (_mobileManager.isIMEIExist(_mobile))
                {
                    MessageBox.Show("IMEI already exist!");
                    return;
                }

                if (_mobileManager.addMobile(_mobile))
                {
                    MessageBox.Show("Mobile Information Saved!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _mobileManager.CloseConnection();
            }
        }

        private void imeiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DigitInput(e))
            {
                MessageBox.Show("IMEI can not contains letters!");
            }
            if ((imeiTextBox.Text.Length == 15) && (e.KeyChar != 8))
            {
                MessageBox.Show("IMEI length can not excced 15 characters!");
                imeiTextBox.MaxLength = 15;
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

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price can not contain letters!");
            }
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
