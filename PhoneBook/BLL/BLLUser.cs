using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLUser
    {
        public void CreateUser(Users u)
        {
            string sql = "INSERT INTO tbl_user VALUES (@U, @P)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@U",u.UserName),
                new SqlParameter("@P", u.Password)
            };
            DAO.IUD(sql, param, CommandType.Text);
        }

        public DataTable CheckUserName(string userName)
        {
            string sql = "Select Username from tbl_user where Username=@U";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@U", userName)
            };
            DataTable dt = DAO.SelectFrom(sql, param, CommandType.Text);
            return dt;
        }

        public DataTable Login(string userName, string password)
        {
            string sql = "Select * from tbl_user where Username=@U and Password=@P";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@U", userName),
                new SqlParameter("@P",password)
            };
            DataTable dt = DAO.SelectFrom(sql, param, CommandType.Text);
            return dt;
        }
    }
}

