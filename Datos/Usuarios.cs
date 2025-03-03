using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Usuarios
    {
        private string _connectionString;

        public Usuarios()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        }

        public bool validateUser(string user, string pass)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM usuarios WHERE username = @username AND password = @password", con))
                {
                    query.Parameters.AddWithValue("@username", user);
                    query.Parameters.AddWithValue("@password", pass);

                    int count = (int)query.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
