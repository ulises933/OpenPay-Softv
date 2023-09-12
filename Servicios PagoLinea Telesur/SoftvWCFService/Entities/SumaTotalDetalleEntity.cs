﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.SumaTotalDetalleEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : SumaTotalDetalle entity
    /// File                    : SumaTotalDetalleEntity.cs
    /// Creation date           : 27/10/2016
    /// Creation time           : 01:09 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class SumaTotalDetalleEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdSession
        /// </summary>
        [DataMember]
        public long? IdSession { get; set; }
        /// <summary>
        /// Property Monto
        /// </summary>
        [DataMember]
        public Decimal? Monto { get; set; }
        #endregion
    }
}

