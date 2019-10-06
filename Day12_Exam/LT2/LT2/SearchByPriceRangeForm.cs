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
    public partial class SearchByPriceRangeForm : Form
    {
        private Mobile _mobile = new Mobile();
        private MobileManager _mobileManager = new MobileManager();

        public SearchByPriceRangeForm()
        {
            InitializeComponent();
        }

        private void SearchByPriceRangeForm_Load(object sender, EventArgs e)
        {
            Display();
            showMobileGridView.Columns.Add("SerialNumber", "SI#");
        }

        private void Display()
        {
            try
            {
                List<Mobile> mobiles =  _mobileManager.ShowData();
                if (mobiles != null)
                {
                    showMobileGridView.Columns.Add("SerialNumber", "SI#");
                    showMobileGridView.DataSource = mobiles;
                }
                else
                {
                    showMobileGridView.Columns.Clear();
                }
                
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                _mobileManager.CloseConnection();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                String price1 = price1TextBox.Text;
                String price2 = price2TextBox.Text;

                if (String.IsNullOrEmpty(price1) || String.IsNullOrEmpty(price2))
                {
                    MessageBox.Show("Insert price range!");
                    return;
                }
                List<Mobile> mobiles = _mobileManager.SearchMobileByPrice(price1, price2);
                if (mobiles != null)
                {
                    showMobileGridView.Columns.Clear();
                    showMobileGridView.Columns.Add("SerialNumber", "SI#");
                    showMobileGridView.DataSource = mobiles;
                }
                else
                {
                    showMobileGridView.Columns.Clear();
                    MessageBox.Show("No Data found!!");
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _mobileManager.CloseConnection();
            }
        }

        private void price1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FloatInput(e))
            {
                MessageBox.Show("Price can not contain letters!");
            }
        }

        private void price2TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void showMobileGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showMobileGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

    }
}
