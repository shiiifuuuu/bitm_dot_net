using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool AddOrder(String name, String quantity, String price)
        {
            bool isAdded = false;
            try
            {
                float totalPrice = float.Parse(price) * int.Parse(quantity);
                String commandString = @"INSERT INTO 
	                                            Orders (OrderItem, Quantity, TotalPrice)
                                            VALUES
	                                            ('" + name + "', " + quantity + ", " + totalPrice + ")";
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
        public bool UpdateOrder(String name, String price, String quantity, String id)
        {
            bool isUpdated = false;
            try
            {
                float totalPrice = float.Parse(price) * int.Parse(quantity);
                String commandString = @"UPDATE Orders
                                            SET
                                            OrderItem = '" + name + "', " +
                                            "Quantity = " + quantity + ", " +
                                            "TotalPrice = " + totalPrice + " " +
                                            "WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    isUpdated = true;
                }
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
                                         WHERE ID='" + id + "'";
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
    }
}
