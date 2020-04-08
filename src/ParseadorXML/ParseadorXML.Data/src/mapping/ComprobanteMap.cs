using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.mapping
{
    public class ComprobanteMap : IEntityTypeConfiguration<Comprobante>
    {
        public void Configure(EntityTypeBuilder<Comprobante> builder)
        {
            builder.ToTable("Comprobantes");

            builder.HasKey(c => c.UUID);

            builder.Property(c => c.Version)
               .IsRequired()
               .HasColumnType("varchar(100)")
               .HasColumnName("Version")
               .HasMaxLength(2);

            builder.Property(c => c.Fecha)
               .HasColumnType("datetime");


            builder.HasOne(b => b.Emisor)
            .WithOne(i => i.Comprobante)
            .HasForeignKey<Emisor>(b => b.UUID);


            builder.HasOne(b => b.Receptor)
           .WithOne(i => i.Comprobante)
           .HasForeignKey<Receptor>(b => b.UUID);



            builder.HasMany(b => b.Conceptos)
            .WithOne(i => i.Comprobante);


        }
    }
}
