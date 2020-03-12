using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Entities.CFDI.Comprobante
{
    public class Comprobante : BaseEntity
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
        public Emisor Emisor { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Receptor Receptor { get; set; }



    }
}
