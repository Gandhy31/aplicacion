using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Codesi.Encuestas.Aplicacion.DTOs
{
    public class EntidadRespuesta<T>
    {
        public T Entidad { get; set; }
        public string Mensaje { get; set; }
    }
}
