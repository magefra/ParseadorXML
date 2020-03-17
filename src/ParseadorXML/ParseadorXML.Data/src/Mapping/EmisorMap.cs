using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Mapping
{
    public class EmisorMap : IEntityTypeConfiguration<Emisor>
    {
        public void Configure(EntityTypeBuilder<Emisor> builder)
        {
            builder.ToTable("Emisores");

            builder.HasKey(p => p.Id);

            builder.Property(c => c.RFC)
               .IsRequired()
               .HasColumnType("varchar(13)")
               .HasColumnName("RFC")
               .HasMaxLength(13);

            builder.Property(c => c.RazonSocial)
               .HasColumnType("RazonSocial");

            //// 1 : 1 => Provider : Address
            //builder.HasOne(f => f.Address)
            //    .WithOne(e => e.Provider);

            //// 1 : N => Provider : Products
            //builder.HasMany(f => f.Products)
            //    .WithOne(p => p.Provider)
            //    .HasForeignKey(p => p.ProviderId);
        }
    }
}
