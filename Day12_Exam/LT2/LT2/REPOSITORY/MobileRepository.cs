using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LT2.MODEL;

namespace LT2.REPOSITORY
{
    class MobileRepository
    {
        private SqlConnection sqlConnection;
        public MobileRepository()
        {
            String connectionString = @"Server=PC-301-21\SQLEXPRESS ; Database=Mobile; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch { }
        }

        public bool addMobile(Mobile _mobile)
        {
            bool isAdded = false;
            String commandString = @"INSERT INTO MobileInformation (ModelName, IMEI, Price)
VALUES ('"+_mobile.ModelName+"','"+_mobile.IMEI+"','"+_mobile.Price+"')";

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

        public List<Mobile> ShowData()
        {
            String commandString = @"SELECT * FROM MobileInformation";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Mobile> mobiles = new List<Mobile>();
            while (sqlDataReader.Read())
            {
                Mobile mobile = new Mobile();
                mobile.ModelName = sqlDataReader["ModelName"].ToString();
                mobile.IMEI = sqlDataReader["IMEI"].ToString();
                mobile.Price = sqlDataReader["Price"].ToString();

                mobiles.Add(mobile);
            }
            sqlConnection.Close();
            return mobiles;
        }

        public List<Mobile> SearchMobileByPrice(string price1, string price2)
        {
            double p1 = double.Parse(price1);
            double p2 = double.Parse(price2);
            String commandString = @"SELECT ModelName, IMEI, Price FROM MobileInformation
                                            WHERE Price BETWEEN " + p1 + " AND " + p2 + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Mobile> mobiles = new List<Mobile>();
            while (sqlDataReader.Read())
            {
                Mobile mobile = new Mobile();
                mobile.ModelName = sqlDataReader["ModelName"].ToString();
                mobile.IMEI = sqlDataReader["IMEI"].ToString();
                mobile.Price = sqlDataReader["Price"].ToString();

                mobiles.Add(mobile);
            }
            sqlConnection.Close();
            return mobiles;
        }

        public Mobile SearchMobileByImei(string searchText)
        {
            Mobile mobile = new Mobile();
            String commandString = @"SELECT ModelName, IMEI, Price FROM MobileInformation
                                            WHERE IMEI = '" + searchText + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                mobile.ModelName = sqlDataReader["ModelName"].ToString();
                mobile.IMEI = sqlDataReader["IMEI"].ToString();
                mobile.Price = sqlDataReader["Price"].ToString();
            }
            sqlConnection.Close();
            return mobile;
        }

        public bool isIMEIExist(Mobile _mobile)
        {
            bool imeiExist = false;
            String commandString = @"SELECT * FROM MobileInformation WHERE IMEI = '" + _mobile.IMEI + "'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                imeiExist = true;
            }

            sqlConnection.Close();

            return imeiExist;
        }
    }
}
