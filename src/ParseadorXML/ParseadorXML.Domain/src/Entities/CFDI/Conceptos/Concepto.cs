using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Entities.CFDI.Comprobante
{
    public class Concepto : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        public double Total { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Comprobante Comprobante { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string UUID { get; set; }



    }
}
