using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Map
{
    class UFMap : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> builder)
        {
            builder.ToTable("BS_004_UF");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.UFs)
                .HasColumnName("UF");
        }
    }
}
