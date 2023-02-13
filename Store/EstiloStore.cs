using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Store
{
    public class EstiloStore
    {
        public List<Estilo> listar()
        {
            List<Estilo> elementos = new List<Estilo>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setQuery("select Id, Descripcion from ESTILOS");
                conexion.EjecutarLectura();

                while (conexion.Lector.Read())
                {
                    Estilo aux = new Estilo();

                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];

                    elementos.Add(aux);                   
                }

                return elementos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
