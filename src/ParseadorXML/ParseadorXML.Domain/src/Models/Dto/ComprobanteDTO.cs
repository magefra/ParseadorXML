using ParseadorXML.Domain.src.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Models.DTO
{


    public class ComprobanteDTO
    {

        /// <summary>
        /// 
        /// </summary>
        public string UUID { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Version { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public DateTime Fecha { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public String Tipo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public EmisorDTO Emisor { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ReceptorDTo Receptor { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ICollection<ConceptoDTO> Conceptos { get; set; }
    }
}
