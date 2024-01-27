using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Codesi.Encuestas.Aplicacion.DTOs
{
    public class EntidadRegistroResultado
    {
        public int Id { get; set; }

        public int IdEncuesta { get; set; }

        public int IdUsuario { get; set; }
        public string ValorResultado { get; set; }
    }
}
