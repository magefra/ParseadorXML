using Microsoft.EntityFrameworkCore;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Context
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedUsers();
        }

        private static void SeedUsers(this ModelBuilder builder)
        {
            builder.Entity<Comprobante>(x =>
            {
                x.HasData(new Comprobante
                {
                    UUID = "DBCE7270-AD5A-8047-B39C-D2E689D6685F",
                    Version = "3.3",
                    Fecha = DateTime.Now,
                    Tipo = "Ingreso"
                });


                x.OwnsOne(c => c.Emisor)
                  .HasData(new
                  {
                      Id = Guid.NewGuid(),
                      UUID = "DBCE7270-AD5A-8047-B39C-D2E689D6685F",
                      RFC = "CAM830905DJ8",
                      RazonSocial = "Empresa ficticia",
                  });

            });          
        }

    }
}
