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
    public class ItemRepository
    {
        private SqlConnection sqlConnection;

        public ItemRepository()
        {
            //Database Connection
            String connectionString = @"Server=PC-301-21\SQLEXPRESS; Database=CoffeeShopCRUD; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddItem(Item _item)
        {
            bool isAdded = false;
            try
            {
                String commandString = @"INSERT INTO 
	                                    Items (Name, Price)
                                    VALUES
	                                    ('" + _item.Name + "', '" + _item.Price + "')";
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
        public bool IsItemExist(Item _item)
        {
            bool isItemExist = false;
            try
            {
                String commandString = @"SELECT * FROM Items
                                            WHERE Name LIKE '" + _item.Name + "'";
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

        public DataTable SearchItem(Item _item)
        {
            DataTable dataTable = new DataTable();
            bool searchSuccess = false;
            try
            {
                String commandString = @"SELECT * FROM Items
                                            WHERE Name LIKE '" + _item.Name + "%'";
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

        public bool DeleteItem(Item _item)
        {
            bool isDeleted = false;
            try
            {
                String commandString = @"DELETE FROM Items
                                         WHERE ID='" + _item.ID + "'";
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
        public bool UpdateItem(Item _item)
        {
            bool isUpdated = false;
            try
            {
                String commandString = @"UPDATE ITEMS 
	                                    SET Name = '" + _item.Name + "', " +
                                            "Price =  " + _item.Price + " " +
                                            "WHERE ID = '" + _item.ID + "' ";
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
