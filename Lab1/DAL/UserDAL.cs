using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab1.DAL
{
    public class UserDAL
    {
        private string connectionString = "Server=localhost;Database=UserDB;Integrated Security=True;";

        public bool ValidateUser(int userId, string password)
        {
            bool isValid = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE UserId = @UserId AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                isValid = count == 1;
            }
            return isValid;
        }
    }
}