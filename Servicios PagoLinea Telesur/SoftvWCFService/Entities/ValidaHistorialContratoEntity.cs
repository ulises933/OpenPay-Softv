﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.ValidaHistorialContratoEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : ValidaHistorialContrato entity
    /// File                    : ValidaHistorialContratoEntity.cs
    /// Creation date           : 07/03/2017
    /// Creation time           : 04:37 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class ValidaHistorialContratoEntity 
    {
        #region Attributes

        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public long? Contrato { get; set; }

        /// <summary>
        /// Property tieneSaldo
        /// </summary>
        [DataMember]
        public int? tieneSaldo { get; set; }

        #endregion
    }
}

