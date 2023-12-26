using AutoMapper;
using ConceptosEFC.DTOs;
using ConceptosEFC.Entidades;

namespace ConceptosEFC.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            //"Mappeo" desde GeneroCreacionDTO hasta Genero
            CreateMap<GeneroCreacionDTO, Genero>();

            //"Mappeo" desde ActorCreacionDTO hasta Actor
            CreateMap<ActorCreacionDTO, Actor>();
        }
    }
}
