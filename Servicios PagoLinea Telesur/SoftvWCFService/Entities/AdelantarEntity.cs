﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.AdelantarEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Adelantar entity
    /// File                    : AdelantarEntity.cs
    /// Creation date           : 28/10/2016
    /// Creation time           : 12:27 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class AdelantarEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdSession
        /// </summary>
        [DataMember]
        public long? IdSession { get; set; }
        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public long? Contrato { get; set; }
        /// <summary>
        /// Property Error
        /// </summary>
        [DataMember]
        public int? Error { get; set; }
        /// <summary>
        /// Property Msg
        /// </summary>
        [DataMember]
        public String Msg { get; set; }
        #endregion
    }
}

