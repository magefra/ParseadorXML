using AutoMapper;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Service.src.Profiles
{
    public class ConceptoProfile : Profile
    {
        public ConceptoProfile()
        {
            CreateMap<Concepto, ConceptoDTO>()
               .ReverseMap();

        }
    }
}
