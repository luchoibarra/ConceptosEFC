using System.ComponentModel.DataAnnotations;

namespace ConceptosEFC.DTOs
{
    public class GeneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}
