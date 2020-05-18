using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class DataProvider
    {
        private string SqlConSTR = ConfigurationManager.AppSettings["connectionStr"];

        private static DataProvider instance;

        public static DataProvider Intstance
        {
            private set { instance = value; }
            get { if (instance == null) Intstance = new DataProvider(); return instance; }
        }

        public DataTable ExcuteQuery(string Query, object[] paraValue = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(SqlConSTR))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                if(paraValue != null)
                {
                    int i = 0;
                    string[] ob = Query.Split(' ');
                    foreach(string obItem in ob )
                    {
                        if(obItem.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(obItem.Replace(',', ' '), paraValue[i].ToString());
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string Query, object[] paraValue = null)
        {
            int data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(SqlConSTR))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                if (paraValue != null)
                {
                    int i = 0;
                    string[] ob = Query.Split(' ');
                    foreach (string obItem in ob)
                    {
                        if (obItem.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(obItem.Replace(',', ' '), paraValue[i].ToString());
                            i++;
                        }
                    }
                }
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                data = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //sqlDataAdapter.Fill(data);
            }
            return data;
        }

        public object ExecuteScalar(string Query, object[] paraValue = null)
        {
            object data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(SqlConSTR))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                if (paraValue != null)
                {
                    int i = 0;
                    string[] ob = Query.Split(' ');
                    foreach (string obItem in ob)
                    {
                        if (obItem.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(obItem.Replace(',', ' '), paraValue[i].ToString());
                            i++;
                        }
                    }
                }
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                data = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                //sqlDataAdapter.Fill(data);
            }
            return data;
        }
    }
}
