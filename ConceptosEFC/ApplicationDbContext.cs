using ConceptosEFC.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ConceptosEFC
{
    public class ApplicationDbContext : DbContext //Pieza central de EFC
    {
        //Genero Constructor con "options" para mandar instrucciones
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Configuro las "convenciones" 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Aplico configuraciones que tengo separadas en diferentes archivos
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            

        }

        //Configuro convenciones globalmente, para no tener que dedicar una config especifica
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        //Configuro clases como entidades
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculasActores => Set<PeliculaActor>();
    }
}