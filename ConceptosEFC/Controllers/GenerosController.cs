using AutoMapper;
using ConceptosEFC.DTOs;
using ConceptosEFC.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ConceptosEFC.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenerosController(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacionDTO generoCreacion) //Derivo al DTO
        {
            //Mando a "AutoMapper" a laburar con el mappeo
            var genero = mapper.Map<Genero>(generoCreacion);

            context.Add(generoCreacion);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
