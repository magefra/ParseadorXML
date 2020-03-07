using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Entities.CFDI.Comprobante
{
    public class Comprobante
    {

        /// <summary>
        /// 
        /// </summary>
        public string UUID { get; set; }


        /// <summary>
        /// Atributo Requerido.
        /// </summary>
        public string Version { get; set; }


        /// <summary>
        /// Atributo Requerido.
        /// </summary>
        public DateTime Fecha { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public String Tipo { get; set; }
    }
}
