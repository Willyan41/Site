using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class TipoSanguineoMap : IEntityTypeConfiguration<TipoSanguineo>
    {
        public void Configure(EntityTypeBuilder<TipoSanguineo> builder)
        {
            builder.ToTable("BS_007_TIPO_SANGUINEO");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.Tipo)
                .HasColumnName("TIPO");
            builder.Property(p => p.FatorRh)
                .HasColumnName("FATOR_RH");
        }
    }
}
