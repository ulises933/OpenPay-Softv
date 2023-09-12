﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.BuscaFacturasHistorialEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : BuscaFacturasHistorial entity
    /// File                    : BuscaFacturasHistorialEntity.cs
    /// Creation date           : 21/10/2016
    /// Creation time           : 04:42 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class BuscaFacturasHistorialEntity 
    {
        #region Attributes

        /// <summary>
        /// Property Clv_Factura
        /// </summary>
        /// 

        [DataMember]
        public int? Id { get; set; }




        [DataMember]
        public long? Clv_Factura { get; set; }
        /// <summary>
        /// Property Status
        /// </summary>
        [DataMember]
        public String Status { get; set; }
        /// <summary>
        /// Property Serie
        /// </summary>
        [DataMember]
        public String Serie { get; set; }
        /// <summary>
        /// Property Folio
        /// </summary>
        [DataMember]
        public long? Folio { get; set; }
        /// <summary>
        /// Property Fecha
        /// </summary>
        [DataMember]
        public String Fecha { get; set; }
        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public String Contrato { get; set; }
        /// <summary>
        /// Property Importe
        /// </summary>
        [DataMember]
        public Decimal? Importe { get; set; }
        /// <summary>
        /// Property Cliente
        /// </summary>
        [DataMember]
        public String Cliente { get; set; }
        /// <summary>
        /// Property Tipo
        /// </summary>
        [DataMember]
        public String Tipo { get; set; }


        [DataMember]
        public long? ContratoO { get; set; }

        
        #endregion
    }
}

