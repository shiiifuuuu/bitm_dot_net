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
            String connectionString = @"Server=PC-301-21\SQLEXPRESS; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private double CalculateTotalPrice(Order _order)
        {
            double itemPrice=0;
            String commandString = @"SELECT DISTINCT ItemId, i.Name, i.Price FROM Orders AS o
                                    LEFT JOIN Items AS i ON i.Id = o.ItemId
                                    WHERE ItemId = '"+_order.ItemId+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                String price = reader["Price"].ToString();
                itemPrice = double.Parse(price);
            }

            //if (sqlCommand.ExecuteNonQuery() > 0)
            //{

            //}

            sqlConnection.Close();

            return itemPrice;

        }
        public bool AddOrder(Order _order)
        {
            bool isAdded = false;
            double totalPrice = CalculateTotalPrice(_order) * int.Parse(_order.Quantity);
            _order.Price = totalPrice + "";
            try
            {
                String commandString = @"INSERT INTO 
	                                            Orders (CustomerId, ItemId, Quantity, Price)
                                            VALUES
	                                            ('" + _order.CustomerId + "', '" + _order.ItemId + "', '" + _order.Quantity + "', '"+_order.Price+"')";
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
        public DataTable SearchOrder(String searchText)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT o.Id, c.Name AS Customer, i.Name AS Item, i.Price, Quantity, o.Price AS TotalPrice FROM Orders AS o
                LEFT JOIN Customers AS c ON c.Id = o.CustomerId
                LEFT JOIN Items AS i ON i.Id = o.ItemId
                WHERE c.Name LIKE '" + searchText + "%' OR i.Name LIKE '" + searchText + "%' OR o.Price LIKE '" + searchText + "%'";

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
        public bool UpdateOrder(Order _order)
        {
            bool isUpdated = false;
            double totalPrice = CalculateTotalPrice(_order) * int.Parse(_order.Quantity);
            _order.Price = totalPrice + "";
            try
            {
                String commandString = @"UPDATE Orders
                                        SET CustomerId = '" + _order.CustomerId + "', " +
                                        "ItemId = '" + _order.ItemId + "', " +
                                        "Quantity = '" + _order.Quantity + "', " +
                                        "Price = '"+_order.Price+"' " +
                                        "WHERE Id = '" + _order.Id + "'";
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
        public bool DeleteOrder(Order _order)
        {
            bool isDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Orders
                                         WHERE Id='" + _order.Id + "'";
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
                String commandString = @"SELECT o.Id, c.Name AS Customer, i.Name AS Item, i.Price, Quantity, o.Price AS TotalPrice FROM Orders AS o
                                        LEFT JOIN Customers AS c ON c.Id = o.CustomerId
                                        LEFT JOIN Items AS i ON i.Id = o.ItemId";
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
