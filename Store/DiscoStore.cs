using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Store
{
    public class DiscoStore
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setQuery("Select D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as Edicion, D.IdEstilo, D.IdTipoEdicion From DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo and T.Id = D.IdTipoEdicion");
                conexion.EjecutarLectura();

                while (conexion.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Titulo = (string)conexion.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)conexion.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)conexion.Lector["CantidadCanciones"];
                    if (!(conexion.Lector["UrlImagenTapa"] is DBNull))
                        aux.ImagenTapa = (string)conexion.Lector["UrlImagenTapa"];
                    aux.EstiloMusical = new Estilo();
                    aux.EstiloMusical.Id = (int)conexion.Lector["IdEstilo"];
                    aux.EstiloMusical.Descripcion = (string)conexion.Lector["Estilo"];
                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.Id = (int)conexion.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)conexion.Lector["Edicion"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void add(Disco nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setQuery("insert into DISCOS (Titulo, CantidadCanciones, FechaLanzamiento, UrlImagenTapa, IdEstilo, IdTipoEdicion) values ('" + nuevo.Titulo + "', " + nuevo.CantidadCanciones + ", @FechaLanzamiento, @UrlImagenTapa, @IdEstilo, @IdTipoEdicion)");
                conexion.setParametros("@FechaLanzamiento", nuevo.FechaLanzamiento);
                conexion.setParametros("@UrlImagenTapa", nuevo.ImagenTapa);
                conexion.setParametros("@IdEstilo", nuevo.EstiloMusical.Id);
                conexion.setParametros("@IdTipoEdicion", nuevo.TipoEdicion.Id);
                
                conexion.EjecutarEscritura();
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

        public void modify(Disco modificado)
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Disco> list = new List<Disco>();
            try
            {
                conexion.setQuery("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento, CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @ImagenTapa, IdEstilo = @Estilo, IdTipoEdicion = @Edicion where Id = @Id");

                conexion.setParametros("@Titulo", modificado.Titulo);
                conexion.setParametros("@FechaLanzamiento", modificado.FechaLanzamiento);
                conexion.setParametros("@CantidadCanciones", modificado.CantidadCanciones);
                conexion.setParametros("@ImagenTapa", modificado.ImagenTapa);
                conexion.setParametros("@Estilo", modificado.EstiloMusical.Id);
                conexion.setParametros("@Edicion", modificado.TipoEdicion.Id);
                conexion.setParametros("@Id", modificado.Id);

                conexion.EjecutarEscritura();
            }
            catch (Exception ex)
            {

                throw ex;

            }finally
            {
                conexion.cerrarConexion();
            }
        }

        public void delete(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Disco> list = new List<Disco>();

            try
            {
                conexion.setQuery("delete from DISCOS where Id = @Id");
                conexion.setParametros("@Id", id);
                conexion.EjecutarEscritura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
