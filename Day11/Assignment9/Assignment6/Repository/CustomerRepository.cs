﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Assignment6.MODEL;

namespace Assignment6.REPOSITORY
{
    public class CustomerRepository
    {
        private SqlConnection sqlConnection;
        //private String server = "Shiiifuuuu";
        //private String server = "PC-301-21\SQLEXPRESS";
        private String database = "CoffeeShopCRUD";
        
        public CustomerRepository()
        {
            //Database Connection
            //String connectionString = "Server="+server+"; Database="+database+"; Integrated Security=True";
            String connectionString = @"Server=PC-301-21\SQLEXPRESS ; Database=CoffeeShopCRUD; Integrated Security=True";
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

        public void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch { }
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

        public List<Customer> ShowData()
        {
            bool trySuccess = false;

            String commandString = @"SELECT Code, Name, Contact, Address, District FROM Customers ORDER BY Code";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //USING DATA ADAPTER
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.Fill(dataTable);

            //NOW USING SQL DATA READER
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Code = sqlDataReader.GetString(0);
                //customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Contact = sqlDataReader["Contact"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.District = sqlDataReader["District"].ToString();

                customers.Add(customer);
            }sqlDataReader.Close();

            trySuccess = true;

            sqlConnection.Close();

            if (trySuccess)
            {
                return customers;
            }
            else
            {
                customers = null;
                return customers;
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
