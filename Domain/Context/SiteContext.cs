using Domain.Entidades;
using Domain.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    class SiteContext : DbContext
    {
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Deficiencia> Deficiencia { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Identidade> Identidade { get; set; }
        public DbSet<Naturalidade> Naturalidade { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Residencia>Residencia { get; set; }
        public DbSet<TipoSanguineo> TipoSanguineo { get; set; }
        public DbSet<UF> UF { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new DeficienciaMap());
            modelBuilder.ApplyConfiguration(new EstadoCivilMap());
            modelBuilder.ApplyConfiguration(new IdentidadeMap());
            modelBuilder.ApplyConfiguration(new NaturalidadeMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ResidenciaMap());
            modelBuilder.ApplyConfiguration(new TipoSanguineoMap());
            modelBuilder.ApplyConfiguration(new UFMap());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Bombinha;Initial Catalog=SITESUS;Integrated Security=True");
        }




    }
}
