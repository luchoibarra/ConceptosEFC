using System.ComponentModel.DataAnnotations;

namespace ConceptosEFC.DTOs
{
    public class ActorCreacionDTO
    {
        [StringLength(150)]
        public string Nombre { get; set; } = null!; //Perdono nulo
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento {  get; set; }
    }
}
