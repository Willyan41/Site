using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class ResidenciaMap : IEntityTypeConfiguration<Residencia>
    {
        public void Configure(EntityTypeBuilder<Residencia> builder)
        {
            builder.ToTable("BS_003_RESIDENCIA");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.CEP)
                .HasColumnName("CEP");
            builder.Property(p => p.Logradouro)
                .HasColumnName("LOGRADOURO");
            builder.Property(p => p.Numero)
                .HasColumnName("NUMERO");
            builder.Property(p => p.Complemento)
                .HasColumnName("COMPLEMENTO");
            builder.Property(p => p.Bairro)
                .HasColumnName("BAIRRO");
            builder.Property(p => p.Cidade)
                .HasColumnName("CIDADE");
            builder.Property(p => p.UF)
                .HasColumnName("UF");
        }
    }
}
