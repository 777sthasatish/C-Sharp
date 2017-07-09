using System;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLContact
    {
        public int CreateContact(Contact contact, byte[] photoArray)
        {
            string sql = "INSERT INTO tbl_contact " +
    "VALUES(@fName,@mName,@lName,@street,@city,@country,@dob,@gender,@contactRelation,@eMail,@mobileNo,@landNo,@image)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@fname",contact.FirstName),
                new SqlParameter("@mName",contact.MiddleName),
                new SqlParameter("@lName",contact.LastName),
                new SqlParameter("@street",contact.Street),
                new SqlParameter("@city",contact.City),
                new SqlParameter("@country",contact.Country),
                new SqlParameter("@dob",contact.DOB),
                new SqlParameter("@gender",contact.Gender),
                new SqlParameter("@contactRelation",contact.ContactRelation),
                new SqlParameter("@eMail",contact.EmailAddress),
                new SqlParameter("@mobileNo",contact.MobileNumber),
                new SqlParameter("@landNo",contact.LandLineNumber),
                new SqlParameter("@image",photoArray)
            };
            return DAO.IUD(sql, param, CommandType.Text);
        }

        public void DeleteContact(string id)
        {
            int contactID = Convert.ToInt32(id);
            string sql = "Delete from tbl_contact where ContactID=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",contactID)
            };
            DAO.IUD(sql, param, CommandType.Text);
        }
        public DataTable GetContacts()
        {
            string sql = "Select ContactImage,FirstName,LastName,ContactID from tbl_contact";
            return DAO.SelectFrom(sql, null, CommandType.Text);
        }

        public DataTable FillForm(string name)
        {
            string sql = "Select * from tbl_Contact where ContactID=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",name)
            };
            return DAO.SelectFrom(sql, param, CommandType.Text);
        }

        public DataTable SearchContact(string value)
        {
            string sql = "Select ContactID,FirstName,LastName,ContactImage from tbl_contact where FirstName=@f or LastName=@l or " +
                "MobileNumber=@m or LandlineNumber=@ln";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@f",value),
                new SqlParameter("@l",value),
                new SqlParameter("@m",value),
                new SqlParameter("@ln",value)
            };
            return DAO.SelectFrom(sql, param, CommandType.Text);
        }
    }
}
