using Microsoft.EntityFrameworkCore;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Infra.Data.EFRepositories.src.mapping;
using ParseadorXML.Infra.Data.EFRepositories.src.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.context
{
    public class CFDIContext : DbContext
    {

        public DbSet<Comprobante> Comprobante { get; set; }

        public DbSet<Emisor> Emisor { get; set; }

        public DbSet<Receptor>  Receptor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            object p = modelBuilder.Entity<Comprobante>(new ComprobanteMap().Configure);
            object c = modelBuilder.Entity<Emisor>(new EmisorMap().Configure);
            object o = modelBuilder.Entity<Receptor>(new ReceptorMap().Configure);
        }


    }
}
