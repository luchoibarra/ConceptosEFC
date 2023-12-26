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

            context.Add(genero);
            await context.SaveChangesAsync(); //Usamos esto para pujar a la base de datos
            return Ok();
        }

        //"mappeo" un arreglo de "GeneroCreacionDTO" a un arreglo de "Generos"
        [HttpPost("varios")]
        public async Task<ActionResult> Post(GeneroCreacionDTO[] generosCreacionDTO)
        {
            var generos = mapper.Map<Genero[]>(generosCreacionDTO);
            context.AddRange(generos);
            await context.SaveChangesAsync(); //Usamos esto para pujar a la base de datos
            return Ok();
        }
    }
}
