using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAO
    {
        public static AppSettingsReader asr = new AppSettingsReader();
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(asr.GetValue("phonebook", typeof(string)).ToString());
          
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            return conn;
        }

        public static int IUD(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
               return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable SelectFrom(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
