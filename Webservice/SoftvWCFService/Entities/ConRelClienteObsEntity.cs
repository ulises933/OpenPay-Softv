﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.ConRelClienteObsEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : ConRelClienteObs entity
    /// File                    : ConRelClienteObsEntity.cs
    /// Creation date           : 20/01/2017
    /// Creation time           : 05:25 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class ConRelClienteObsEntity 
    {
        #region Attributes

        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public long? Contrato { get; set; }
        /// <summary>
        /// Property Obs
        /// </summary>
        [DataMember]
        public String Obs { get; set; }
        #endregion
    }
}
