﻿using AutoMapper;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Service.src.Profiles
{
    public class EmisorProfile : Profile
    {
        public EmisorProfile()
        {
            CreateMap<Emisor, EmisorDTO>()
              .ReverseMap();
        }
    }
}
