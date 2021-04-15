using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("BS_001_PESSOA");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.Nome)
                .HasColumnName("PESSOA_NOME");
            builder.Property(p => p.CPF)
                .HasColumnName("CPF");
            builder.Property(p => p.DataNascimento)
                .HasColumnName("DATA_NASCIMENTO");
            builder.Property(p => p.Sexo)
                .HasColumnName("SEXO");
            builder.Property(p => p.Contato)
                .HasColumnName("CONTATO");
            builder.Property(p => p.Deficiencia)
                .HasColumnName("DEFICIENCIA");
            builder.Property(p => p.TipoSanguineo)
                .HasColumnName("TIPO_SANGUINEO");
            builder.Property(p => p.EstadoCivil)
                .HasColumnName("ESTADO_CIVIL");
            builder.Property(p => p.Naturalidade)
                .HasColumnName("NATURALIDADE");
            builder.Property(p => p.Residencia)
                .HasColumnName("RESIDENCIA");

        }
    }
}
