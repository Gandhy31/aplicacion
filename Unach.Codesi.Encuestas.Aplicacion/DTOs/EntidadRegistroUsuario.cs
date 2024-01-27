using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unach.Codesi.Encuestas.Persistencia.Core.Models;

namespace Unach.Codesi.Encuestas.Aplicacion.DTOs
{
    public class EntidadRegistroUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
