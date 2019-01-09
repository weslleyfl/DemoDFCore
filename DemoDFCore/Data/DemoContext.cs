using DemoDFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFCore.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options )
            :base(options)
        {

        }
        
        public DbSet<Evento> Eventos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                .Property(c => c.Id)
                .HasColumnName("EventoId");

            modelBuilder.Entity<Evento>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Descricao)
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Email)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)                
                .IsRequired(false);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Data);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Gratuito);
                //.HasColumnType("bit")
                //.IsRequired(false);


            modelBuilder.Entity<Evento>()
             .Property(c => c.Valor)
             .HasColumnType("decimal(18,2)");
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
