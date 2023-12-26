namespace ConceptosEFC.Entidades
{
    public class Actor
    {
        public int Id {  get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //Coloco Listado para ordenar PeliculaActor
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
    }
}
