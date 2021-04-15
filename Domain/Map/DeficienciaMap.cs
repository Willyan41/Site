using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class DeficienciaMap : IEntityTypeConfiguration<Deficiencia>
    {
        public void Configure(EntityTypeBuilder<Deficiencia> builder)
        {

            builder.ToTable("BS_008_DEFICIENCIA");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.Tipo)
                .HasColumnName("TIPO");

        }
    }
}
