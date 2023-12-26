namespace ConceptosEFC.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        //Configuro mi relacion N:N entre Peliculas y Genero
        public HashSet<Pelicula> Peliculas { get; set; } = new HashSet<Pelicula>(); 
    }
}