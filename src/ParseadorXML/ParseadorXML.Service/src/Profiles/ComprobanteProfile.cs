using AutoMapper;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Autor: Magdiel Efrain Palacios Rivera.
/// Fecha: 05-04-2020
/// Hora: 00:51
/// </summary>

namespace ParseadorXML.Service.src.Profiles
{

    /// <summary>
    /// TODO: La finalidad es que el comprobante pueda tener todo lo que contiene del
    ///       CFDI
    /// </summary>
    public class ComprobanteProfile : Profile
    {
        public ComprobanteProfile()
        {
            CreateMap<Comprobante, ComprobanteDTO>()
                .ReverseMap();
        }
    }
}
