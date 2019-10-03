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

        public CustomerRepository()
        {
            //Database Connection
            String connectionString = @"Server=PC-301-21\SQLEXPRESS; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddCustomer(Customer _customer)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO
                                            Customers (Name, Contact, Address)
                                            VALUES
                                            ('" + _customer.Name + "', '" + _customer.Contact + "', '" + _customer.Address + "')";

                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int queryCheck = sqlCommand.ExecuteNonQuery();
                if (queryCheck > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();
            }
            catch { }
            return isAdded;
        }

        public DataTable SearchCustomer(String searchText)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Customers
                                            WHERE Name LIKE '" + searchText + "%' OR Contact LIKE '"+searchText+"' OR Address LIKE '"+searchText+"'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    searchSuccess = true;
                }

                sqlConnection.Close();
            }
            catch { }

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

        public bool UpdateCustomer(Customer _customer)
        {
            bool customerUpdated = false;
            try
            {
                String commandString = @"UPDATE Customers
                                            SET Name = '" + _customer.Name + "', " +
                                              "Contact = '" + _customer.Contact + "', " +
                                              "Address = '" + _customer.Address + "' " +
                                              "WHERE ID = '" + _customer.Id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int queryCheck = sqlCommand.ExecuteNonQuery();
                if (queryCheck > 0)
                {
                    customerUpdated = true;
                }

                sqlConnection.Close();
            }
            catch { }

            return customerUpdated;
        }

        public bool DeleteCustomer(Customer _customer)
        {
            bool customerDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Customers
                                         WHERE ID='" + _customer.Id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int queryCheck = sqlCommand.ExecuteNonQuery();
                if (queryCheck > 0)
                {
                    customerDeleted = true;
                }

                sqlConnection.Close();
            }
            catch { }
            return customerDeleted;
        }

        public DataTable ShowData()
        {
            bool trySuccess = false;
            DataTable dataTable = new DataTable();
            try
            {
                String commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                trySuccess = true;

                sqlConnection.Close();
            }
            catch { }

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

        public bool isCustomerExist(Customer _customer)
        {
            bool customerExist = false;
            String commandString = @"SELECT * FROM Customers WHERE Name LIKE '" + _customer.Name + "%'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                customerExist = true;
            }

            sqlConnection.Close();

            return customerExist;
        }
    }
}
