﻿using ConceptosEFC.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConceptosEFC.ConfiguracionesEntidades
{
    public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {
            builder.HasKey(pa => new {pa.ActorId, pa.PeliculaId});
        }
    }
}
