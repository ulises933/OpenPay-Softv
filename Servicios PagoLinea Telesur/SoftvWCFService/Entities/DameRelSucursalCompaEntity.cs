﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.DameRelSucursalCompaEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : DameRelSucursalCompa entity
    /// File                    : DameRelSucursalCompaEntity.cs
    /// Creation date           : 27/10/2016
    /// Creation time           : 11:28 a. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class DameRelSucursalCompaEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdSucursal
        /// </summary>
        [DataMember]
        public int? IdSucursal { get; set; }
        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public long? Contrato { get; set; }
        /// <summary>
        /// Property Id
        /// </summary>
        [DataMember]
        public int? Id { get; set; }
        #endregion
    }
}
