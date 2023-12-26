﻿using ConceptosEFC.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ConceptosEFC.ConfiguracionesEntidades
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        { 
            builder.Property(p => p.FechaEstreno).HasColumnType("date");
        }
    }
}
