using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("BS_002_CONTATO");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.TelFixo)
                .HasColumnName("TEL_FIXO");
            builder.Property(p => p.TelCel)
                .HasColumnName("TEL_CEL");
            builder.Property(p => p.Email)
                .HasColumnName("EMAIL");

        }
    }
}
