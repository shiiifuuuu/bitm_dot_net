using Assignment6.MANAGER;
using System;
using System.Data;
using System.Windows.Forms;
using Assignment6.MODEL;

namespace Assignment6.UI
{
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager = new CustomerManager();
        private Customer _customer = new Customer();
        private Helper _helper = new Helper();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                if (_customerManager.ShowData().Rows.Count == 0)
                {
                    showDataGridView.Columns.Clear();
                    confirmationLabel.Text = "No data Exist in the database!";
                    return;
                }
                if (_customerManager.ShowData().Rows.Count > 0)
                {
                    showDataGridView.Columns.Add("SerialNumber", "SI");
                    showDataGridView.DataSource = _customerManager.ShowData();
                    showDataGridView.Columns[showDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }

        private void addUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Code = codeTextBox.Text;
                _customer.Name = nameTextBox.Text;
                _customer.Contact = contactTextBox.Text;
                _customer.Address = addressTextBox.Text;
                _customer.District = districtComboBox.Text;

                if (!isNullOrEmpty(_customer))
                {
                    return;
                }

                if (addUpdateButton.Text == "Add")
                {
                    if (!isUnique(_customer))
                    {
                        return;
                    }
                    if (_customerManager.AddCustomer(_customer))
                    {
                        CleanAll();
                        Display();
                        confirmationLabel.ForeColor = System.Drawing.Color.Green;
                        confirmationLabel.Text = "Customer " + _customer.Code + " added Successfully";
                    }
                }
                if (addUpdateButton.Text == "Update")
                {
                    if (_customerManager.UpdateCustomer(_customer))
                    {
                        CleanAll();
                        Display();
                        confirmationLabel.ForeColor = System.Drawing.Color.Green;
                        confirmationLabel.Text = "Customer " + _customer.Code + " updated Successfully";
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }

        private bool isNullOrEmpty(Customer _customer)
        {
            if (String.IsNullOrEmpty(_customer.Code))
            {
                errorCodeLabel.Text = "Insert Code value!!";
                return false;
            }
            else if (_customer.Code.Length < 4)
            {
                errorCodeLabel.Text = "Code requires 4 characters";
                return false;
            }
            else
            {
                errorCodeLabel.Text = null;

            }
            if (String.IsNullOrEmpty(_customer.Name))
            {
                errorNameLabel.Text = "Insert Name!!";
                return false;
            }
            else
            {
                errorNameLabel.Text = null;
            }
            if (String.IsNullOrEmpty(_customer.Contact))
            {
                errorContactLabel.Text = "Insert Contact Number!!";
                return false;
            }else if(_customer.Contact.Length < 11)
            {
                errorContactLabel.Text = "Contact requires 11 digits";
                return false;
            }
            else
            {
                errorContactLabel.Text = null;
            }
            if (_customer.District == "--Select--" || String.IsNullOrEmpty(_customer.District))
            {
                errorDistrictCombo.Text = "Select a district!!";
                return false;
            }
            else
            {
                errorDistrictCombo.Text = null;
            }
            return true;
        }

        private bool isUnique(Customer _customer)
        {
            bool isUnique = false;
            try
            {
                if (_customerManager.isCodeExist(_customer))
                {
                    errorCodeLabel.Text = "Code already exist!";
                    return isUnique;
                }
                else
                {
                    errorCodeLabel.Text = null;
                }
                if (_customerManager.isContactExist(_customer))
                {
                    errorContactLabel.Text = "Contact already exist!!";
                    return isUnique;
                }
                else
                {
                    errorContactLabel.Text = null;
                }
                isUnique = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
            return isUnique;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                String searchText = searchCustomerTextBox.Text;
                if (String.IsNullOrEmpty(searchText))
                {
                    errorSearchLabel.Text = "Insert a value for Searching";
                    return;
                }
                else
                {
                    errorSearchLabel.Text = null;
                }
                DataTable dataTable = _customerManager.SearchCustomer(searchText);
                CleanAll();
                if (dataTable != null)
                {
                    showDataGridView.DataSource = dataTable;
                    confirmationLabel.ForeColor = System.Drawing.Color.Green;
                    confirmationLabel.Text = dataTable.Rows.Count.ToString() + " Result Found!";
                }
                else
                {
                    showDataGridView.Columns.Clear();
                    errorSearchLabel.Text = "Nothing Found!";
                }
                searchCustomerTextBox.Text = searchText;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Code = deleteCustomerTextBox.Text;

                bool customerDeleted = _customerManager.DeleteCustomer(_customer);
                if (customerDeleted)
                {
                    Display();
                    confirmationLabel.ForeColor = System.Drawing.Color.Green;
                    confirmationLabel.Text = "Customer " + _customer.Code + " Deleted Successfully!";
                }
                else
                {
                    confirmationLabel.Text = "Customer Could not be deleted!!";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            CleanAll();
            try
            {
                DataTable dataTable = _customerManager.ShowData();
                if (dataTable.Rows.Count == 0)
                {
                    dataTable.Columns.Clear();
                    confirmationLabel.Text = "No Data Found!";
                    return;
                }
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;

                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }

        private void Display()
        {
            try
            {
                if (_customerManager.ShowData().Rows.Count == 0)
                {
                    showDataGridView.Columns.Clear();
                    confirmationLabel.Text = "No data Exist in the database!";
                    return;
                }
                if (_customerManager.ShowData().Rows.Count > 0)
                {
                    showDataGridView.DataSource = _customerManager.ShowData();
                    showDataGridView.Columns[showDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _customerManager.CloseConnection();
            }
        }

        private void CleanAll()
        {
            codeTextBox.Text = null;
            nameTextBox.Text = null;
            contactTextBox.Text = null;
            addressTextBox.Text = null;
            districtComboBox.Text = "--Select--";
            searchCustomerTextBox.Text = null;
            deleteCustomerTextBox.Text = null;

            errorCodeLabel.Text = null;
            errorNameLabel.Text = null;
            errorContactLabel.Text = null;
            errorDistrictCombo.Text = null;
            errorSearchLabel.Text = null;
            confirmationLabel.Text = null;

            addUpdateButton.Text = "Add";
        }


        //K E Y  P R E S S
        private void codeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((codeTextBox.Text.Length == 4) && (e.KeyChar != 8))
            {
                errorCodeLabel.Text = "Code length can not exceed 4 characters!";
                codeTextBox.MaxLength = 4;
            }
        }
        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_helper.TextInput(e))
            {
                errorNameLabel.Text = "Name requires only letters!";
            }
        }
        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = _helper.DigitInput(e);
            if (!isDigit)
            {
                errorCodeLabel.Text = "Contact number requires only Digits!";
            }

            if (contactTextBox.Text.Length == 11)
            {
                errorContactLabel.Text = "Contact length can not exceed 11 digits!";
                contactTextBox.MaxLength = 11;
            }
        }
        //K E Y  P R E S S


        //D O U B L E   C L I C K
        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showDataGridView.CurrentRow.Selected = true;

                codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                districtComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["District"].Value.ToString();

                String id = _customerManager.findId(codeTextBox.Text);

                _customer.Id = id;

                addUpdateButton.Text = "Update";

                deleteCustomerTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            }
        }
        //D O U B L E   C L I C K

       
        //Show serial # on gridview
        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

    }
}
