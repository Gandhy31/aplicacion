using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unach.Codesi.Encuestas.Persistencia.Core.Models;

namespace Unach.Codesi.Encuestas.Aplicacion.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Encuesta, EntidadRegistroEncuesta>();
            CreateMap<EntidadRegistroEncuesta, Encuesta>();
            CreateMap<Resultado, EntidadRegistroResultado>();
            CreateMap<EntidadRegistroResultado, Resultado>();
            CreateMap<Usuario, EntidadRegistroUsuario>();
            CreateMap<EntidadRegistroUsuario, Usuario>();
        }
    }
}
