using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class IdentidadeMap : IEntityTypeConfiguration<Identidade>
    {
        public void Configure(EntityTypeBuilder<Identidade> builder)
        {
            builder.ToTable("BS_009_IDENTIDADE");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.RegistroGeral)
                .HasColumnName("REGISTRO_GERAL");
            builder.Property(p => p.OrgaoEmissor)
                .HasColumnName("ORGAO_EMISSOR");
            builder.Property(p => p.UF)
                .HasColumnName("UF");

        }


    }
}
