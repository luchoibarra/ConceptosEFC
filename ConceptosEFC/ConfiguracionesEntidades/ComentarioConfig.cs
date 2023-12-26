using ConceptosEFC.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConceptosEFC.ConfiguracionesEntidades
{
    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.Property(c => c.Contenido).HasMaxLength(500);
        }
    }
}
