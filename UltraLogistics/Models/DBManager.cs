using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UltraLogistics.Models
{
    public class DBManager
    {
        string con = "Data Source=APS-LAMBERDAR\\SQLEXPRESS01;Initial Catalog=Logistic;Integrated Security=True";
        private SqlConnection connection;

        public DBManager()
        {
            connection = new SqlConnection(con);
        }

        public bool IUD(string Proc,SqlParameter[] prams)
        {
            bool res = false;
            try
            {
                SqlCommand sql = new SqlCommand(Proc, connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddRange(prams);
                connection.Open();
                int n= sql.ExecuteNonQuery();
                connection.Close();
                res = n > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }

        public DataTable Proc_GetAllRecord(string Proc,SqlParameter[] prams)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(Proc, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddRange(prams);
                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                sqlData.Fill(dt);
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }

}