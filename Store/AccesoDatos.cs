using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Store
{
    public class AccesoDatos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        SqlDataReader lector;
        public SqlDataReader Lector { get => lector; }

        public AccesoDatos()
        {
            conexion.ConnectionString = "server= .\\SQLEXPRESS; Database= DISCOS_DB; Trusted_Connection=True";
            comando = new SqlCommand();
        }

        public void setQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarEscritura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
