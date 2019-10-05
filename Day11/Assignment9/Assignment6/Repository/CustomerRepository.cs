using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Assignment6.MODEL;

namespace Assignment6.REPOSITORY
{
    public class CustomerRepository
    {
        private SqlConnection sqlConnection;
        private String server = "Shiiifuuuu";
        private String database = "CoffeeShopCRUD";

        public CustomerRepository()
        {
            //Database Connection
            String connectionString = "Server="+server+"; Database="+database+"; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddCustomer(Customer _customer)
        {
            bool isAdded = false;
            String commandString = @"INSERT INTO
                        Customers (Code, Name, Contact, Address, District)
                        VALUES
                        ('" + _customer.Code + "', '" + _customer.Name + "', '" + _customer.Contact + "', '" + _customer.Address + "', '" + _customer.District + "')";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int queryCheck = sqlCommand.ExecuteNonQuery();
            if (queryCheck > 0)
            {
                isAdded = true;
            }

            sqlConnection.Close();
            return isAdded;
        }


        public DataTable SearchCustomer(String searchText)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            String commandString = @"SELECT Code, Name, Contact, Address, District FROM Customers
                                            WHERE Code LIKE '%" + searchText+"%' OR Name LIKE '%" + searchText + "%' " +
                                            "OR Contact LIKE '%" + searchText + "%' OR Address LIKE '%" + searchText + "%' " +
                                            "OR District LIKE '%"+searchText+"%'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                searchSuccess = true;
            }

            sqlConnection.Close();

            if (searchSuccess)
            {
                return dataTable;
            }
            else
            {
                dataTable = null;
                return dataTable;
            }
        }

        public string findId(string customerCode)
        {
            String id = null;
            String commandString = @"SELECT Id FROM Customers
                                            WHERE Code = '" + customerCode + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id = reader["Id"].ToString();
            }

            sqlConnection.Close();
            return id;
        }

        public bool UpdateCustomer(Customer _customer)
        {
            bool customerUpdated = false;
            String commandString = @"UPDATE Customers
                                            SET Code = '"+_customer.Code+"'," +
                                            "Name = '" + _customer.Name + "', " +
                                            "Contact = '" + _customer.Contact + "', " +
                                            "Address = '" + _customer.Address + "', " +
                                            "District = '"+_customer.District+"' " +
                                            "WHERE ID = '" + _customer.Id + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int queryCheck = sqlCommand.ExecuteNonQuery();
            if (queryCheck > 0)
            {
                customerUpdated = true;
            }

            sqlConnection.Close();

            return customerUpdated;
        }

        public bool DeleteCustomer(Customer _customer)
        {
            bool customerDeleted = false;
            String commandString = @"DELETE FROM Customers
                                         WHERE Code='" + _customer.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int queryCheck = sqlCommand.ExecuteNonQuery();
            if (queryCheck > 0)
            {
                customerDeleted = true;
            }

            sqlConnection.Close();
            return customerDeleted;
        }

        public DataTable ShowData()
        {
            bool trySuccess = false;
            DataTable dataTable = new DataTable();

            String commandString = @"SELECT Code, Name, Contact, Address, District FROM Customers ORDER BY Code";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);

            trySuccess = true;

            sqlConnection.Close();

            if (trySuccess)
            {
                return dataTable;
            }
            else
            {
                dataTable = null;
                return dataTable;
            }
        }

        public bool isCodeExist(Customer _customer)
        {
            bool customerCode = false;
            String commandString = @"SELECT * FROM Customers WHERE Code LIKE '" + _customer.Code + "%'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                customerCode = true;
            }

            sqlConnection.Close();

            return customerCode;
        }

        public bool isContactExist(Customer _customer)
        {
            bool contact = false;
            String commandString = @"SELECT * FROM Customers WHERE Contact LIKE '" + _customer.Contact + "%'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                contact = true;
            }

            sqlConnection.Close();

            return contact;
        }
    }
}
