using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInformationForm
{
    public partial class ItemInformationForm : Form
    {
        string connectionString;
        SqlConnection sqlConnection;

        public ItemInformationForm()
        {
            InitializeComponent();
        }

        private void ItemInformationForm_Load(object sender, EventArgs e)
        {
            //Connection
            connectionString = @"Server=PC-301-21\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Command
            string commandString = @"INSERT INTO Items (Name, Price) VALUES ('" + nameTextBox.Text + "', " + priceTextBox.Text + ")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Command
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDataGridView.DataSource = dataTable;

            //Close
            sqlConnection.Close();
        }

    }
}
