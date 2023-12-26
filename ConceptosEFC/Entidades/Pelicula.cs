namespace ConceptosEFC.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool enCines { get; set; }
        public DateTime FechaEstreno {  get; set; }

        //Configuro mi relacion 1:N
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();
        //Configuro mi relacion N:N entre Peliculas y Genero
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
        //Coloco Listado para ordenar PeliculaActor
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
    }
}
