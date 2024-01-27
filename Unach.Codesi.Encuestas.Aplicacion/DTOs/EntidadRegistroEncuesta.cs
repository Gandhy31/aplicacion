using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Codesi.Encuestas.Aplicacion.DTOs
{
    public class EntidadRegistroEncuesta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Periodo { get; set; }
        public string Dependencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string ValoresEncuesta { get; set; }
    }
}
