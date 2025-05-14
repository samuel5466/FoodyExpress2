using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyExpress2.DB
{
    class DBConnection
    {
        string _ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FoodyExpressDB;Integrated Security=True";
        public SqlConnection _Connection
        {
            get
            {
                var conn = new SqlConnection(_ConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static class UserRepository
        {
            public static string GetUserRole(string username, string password)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["FoodyExpressDB"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", username.ToLower());
                        cmd.Parameters.AddWithValue("@Password", password);

                        object role = cmd.ExecuteScalar();

                        return role != null ? role.ToString() : null;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Database error during login: " + ex.Message);
                    }
                }
            }
        }
    }


}

