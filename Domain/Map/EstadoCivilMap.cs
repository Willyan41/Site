using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class EstadoCivilMap : IEntityTypeConfiguration<EstadoCivil>
    {
        public void Configure(EntityTypeBuilder<EstadoCivil> builder)
        {
            builder.ToTable("BS_006_ESTADO_CIVIL");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.EstadosCivis)
                .HasColumnName("ESTADO_CIVIL");

        }


    }
}
