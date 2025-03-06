using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Datos
{
    public class Medicamentos
    {
        private readonly string _connectionString;

        public Medicamentos()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        }

        public DataTable getMedicamentos()
        {
            DataTable dt = new DataTable();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from medicamentos", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool addMedicamento(string nombre, int stock, float precio, DateTime fecha_vencimiento)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSER INTO medicamentos" +
                    "(nombre, stock, precio, fecha_vencimiento, status)" +
                    "VALUES (@nombre, @stock, @precio, @fecha_vencimiento, true)"))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento);

                    int filesAffected = cmd.ExecuteNonQuery();
                    return filesAffected > 0;
                }
            }
        }
    }
}
