using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.MODEL;

namespace Assignment6.REPOSITORY
{
    public class OrderRepository
    {
        private SqlConnection sqlConnection;
        public OrderRepository()
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddOrder(Order _order)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO 
	                                            Orders (CustomerId, ItemId, Quantity)
                                            VALUES
	                                            ('" + _order.CustomerId + "', '" + _order.ItemId + "', '" + _order.Quantity + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();
            }
            catch { }

            return isAdded;
        }
        public DataTable SearchOrder(String name)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Orders
                                            WHERE OrderItem LIKE '" + name + "%'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                searchSuccess = true;

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
        public bool UpdateOrder(String quantity)
        {
            bool isUpdated = false;
            try
            {
                //float totalPrice = float.Parse(price) * int.Parse(quantity);
                //String commandString = @"UPDATE Orders
                //                            SET
                //                            OrderItem = '" + name + "', " +
                //                            "Quantity = " + quantity + ", " +
                //                            "TotalPrice = " + totalPrice + " " +
                //                            "WHERE Id = " + id + "";
                //SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                //if (sqlCommand.ExecuteNonQuery() > 0)
                //{
                //    isUpdated = true;
                //}
                sqlConnection.Close();

            }
            catch { }

            return isUpdated;
        }
        public bool DeleteOrder(String id)
        {
            bool isDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Orders
                                         WHERE Id='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    isDeleted = true;
                }

                sqlConnection.Close();
            }
            catch { }
            return isDeleted;
        }

        public DataTable ShowData()
        {
            bool trySuccess = false;
            DataTable dataTable = new DataTable();
            try
            {
                String commandString = @"SELECT * FROM Orders";
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

        public DataTable ItemComboShow()
        {
            bool trySuccess = false;
            DataTable dataTable = new DataTable();
            try
            {
                String commandString = @"SELECT Id, Name FROM Items";
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
        public DataTable CustomerComboShow()
        {
            bool trySuccess = false;
            DataTable dataTable = new DataTable();
            try
            {
                String commandString = @"SELECT Id, Name FROM Customers";
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
    }
}
