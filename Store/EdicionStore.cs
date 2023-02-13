using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Store
{
    public class EdicionStore
    {
        public List<Edicion> listar()
        {
			List<Edicion> ediciones = new List<Edicion>();
			AccesoDatos conexion = new AccesoDatos();

			try
			{
				conexion.setQuery("select Id, Descripcion from TIPOSEDICION");
				conexion.EjecutarLectura();

				while (conexion.Lector.Read())
				{
					Edicion aux = new Edicion();

					aux.Id = (int)conexion.Lector["Id"];
					aux.Descripcion = (string)conexion.Lector["Descripcion"];

					ediciones.Add(aux);
				}

				return ediciones;
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
