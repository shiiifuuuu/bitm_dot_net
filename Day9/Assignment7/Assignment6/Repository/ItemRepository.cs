using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.REPOSITORY
{
    public class ItemRepository
    {
        private SqlConnection sqlConnection;

        public ItemRepository()
        {
            //Database Connection
            String connectionString = @"Server=SHIIIFUUUU; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddItem(String name, String price)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO 
	                                    Items (ItemName, Price)
                                    VALUES
	                                    ('" + name + "', " + price + ")";
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
        public bool IsItemExist(String name)
        {
            bool isItemExist = false;
            try
            {
                String commandString = @"SELECT * FROM Items
                                            WHERE ItemName LIKE '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isItemExist = true;
                }

                sqlConnection.Close();
            }
            catch { }

            return isItemExist;
        }

        public DataTable SearchItem(String name)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Items
                                            WHERE ItemName LIKE '" + name + "%'";
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

        public bool DeleteItem(String id)
        {
            bool isDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Items
                                         WHERE ID='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int queryCheck = sqlCommand.ExecuteNonQuery();
                if (queryCheck > 0)
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
            DataTable dataTable = new DataTable();
            bool trySuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Items";
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
        public bool UpdateItem(String name, String price, String id)
        {
            bool isUpdated = false;
            try
            {
                String commandString = @"UPDATE ITEMS 
	                                    SET ItemName = '" + name + "', " +
                                            "Price =  " + price + " " +
                                            "WHERE ID = '" + id + "' ";
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
    }
}
