using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Proveedores
    {
        private readonly string _connectionString;

        public Proveedores()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        }

        public DataTable getProveedores()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM proveedores WHERE status = 1", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool addProveedor(string nombre, string telefono, string direccion, string correo)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO proveedores" +
                    "(nombre, telefono, direccion, correo, status)" +
                    "VALUES (@nombre, @telefono, @direccion, @correo, 1)", con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    int filesAffected = cmd.ExecuteNonQuery();
                    return filesAffected > 0;
                }
            }
        }

        public bool updateProveedor(int id, string nombre, string telefono, string direccion, string correo)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE proveedores SET" +
                    "nombre = @nombre, " + 
                    "telefono = @telefono, " +
                    "direccion = @direccion, " +
                    "correo = @correo +" +
                    "WHERE id = @id ",con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    int filesAffected = cmd.ExecuteNonQuery();
                    return filesAffected > 0;
                }
            }
        }

        public bool deleteProveedor(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE proveedores SET " +
                    "status = 0" +
                    "WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int filesAffected = cmd.ExecuteNonQuery();
                    return filesAffected > 0;
                }
            }
        }
    }
}
