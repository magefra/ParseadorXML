﻿using System;
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


        /// <summary>
        /// 
        /// </summary>
        public ICollection<Concepto> Conceptos { get; set; }




        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set
            {
                _createAt = value == null ? DateTime.UtcNow : value;
            }
        }



    }
}
