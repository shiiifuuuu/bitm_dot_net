using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Assignment6.REPOSITORY
{
    public class CustomerRepository
    {
        private SqlConnection sqlConnection;

        public CustomerRepository()
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddCustomer(String name, String contact, String address)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO
                                            Customers (CustomerName, Contact, Address)
                                            VALUES
                                            ('" + name + "', '" + contact + "', '" + address + "')";

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

        public DataTable SearchCustomer(String name)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Customers
                                            WHERE CustomerName LIKE '" + name + "%'";
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

        public bool UpdateCustomer(String name, String contact, String address, String id)
        {
            bool customerUpdated = false;
            try
            {
                String commandString = @"UPDATE Customers
                                            SET
                                            CustomerName = '" + name + "', " +
                                              "Contact = '" + contact + "', " +
                                              "Address = '" + address + "' " +
                                              "WHERE ID = '" + id + "'";
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

        public bool DeleteCustomer(String id)
        {
            bool customerDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Customers
                                         WHERE ID='" + id + "'";
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

        public bool isCustomerExist(String name)
        {
            bool customerExist = false;
            String commandString = @"SELECT * FROM Customers WHERE CustomerName LIKE '" + name + "%'";

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
