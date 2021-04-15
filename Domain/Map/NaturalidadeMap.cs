using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class NaturalidadeMap : IEntityTypeConfiguration<Naturalidade>
    {
        public void Configure(EntityTypeBuilder<Naturalidade> builder)
        {
            builder.ToTable("BS_005_NATURALIDADE");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.UF)
                .HasColumnName("UF");
            builder.Property(p => p.Naturalidad)
                .HasColumnName("NATURALIDADE");
            builder.Property(p => p.Nacionalidade)
                .HasColumnName("NACIONALIDADE");
        }
    }
}
