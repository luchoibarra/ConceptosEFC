using AutoMapper;
using ConceptosEFC.DTOs;
using ConceptosEFC.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ConceptosEFC.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class ActoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ActoresController(ApplicationDbContext context, IMapper mapper) //use autocompletado para crear todo como "campo"
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(ActorCreacionDTO actorCreacionDTO)
        {
            //"mappeo" de ActorCreacionDTO a Actor
            var actor = mapper.Map<Actor>(actorCreacionDTO);
            context.Add(actor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
