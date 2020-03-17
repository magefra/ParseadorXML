using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Mapping
{
    public class ReceptorMap : IEntityTypeConfiguration<Receptor>
    {
        public void Configure(EntityTypeBuilder<Receptor> builder)
        {
            throw new NotImplementedException();
        }
    }
}
