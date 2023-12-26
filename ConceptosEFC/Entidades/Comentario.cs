namespace ConceptosEFC.Entidades
{
    public class Comentario
    {
        public int id {  get; set; }
        public string? Contenido { get; set; }  //? significa "nullable"
        public bool Recomendar {  get; set; }

        //Esto es para configurar relaciones entre registros
        public int PeliculaId {  get; set; }  //convencion para llave foranea
        public Pelicula Pelicula { get; set; } = null!;
    }
}
