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

        public DbSet<Receptor> Receptor { get; set; }


        public CFDIContext(DbContextOptions<CFDIContext> options)
            : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comprobante>(new ComprobanteMap().Configure);
            modelBuilder.Entity<Emisor>(new EmisorMap().Configure);
            modelBuilder.Entity<Receptor>(new ReceptorMap().Configure);
        }

    }
}
