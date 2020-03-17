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
            throw new NotImplementedException();
        }
    }
}
