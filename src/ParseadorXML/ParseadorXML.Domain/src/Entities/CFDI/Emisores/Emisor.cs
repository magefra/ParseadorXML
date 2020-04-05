using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Entities.CFDI.Comprobante
{
    public class Emisor : Entity
    {

        /// <summary>
        /// 
        /// </summary>
        public string RFC { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string RazonSocial { get; set; }



        public Comprobante Comprobante { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string UUID { get; set; }
    }
}
