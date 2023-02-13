using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string ImagenTapa { get; set; }
        public Estilo EstiloMusical { get; set; }
        public Edicion TipoEdicion { get; set; }

    }
}
