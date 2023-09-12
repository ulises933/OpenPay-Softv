﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.BanamexEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Banamex entity
    /// File                    : BanamexEntity.cs
    /// Creation date           : 19/07/2017
    /// Creation time           : 11:31 a. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class LinkEntity 
    {
        #region Attributes
        
        /// <summary>
        /// Property linkRegistro
        /// </summary>
        [DataMember]
        public String linkRegistro { get; set; }
        /// <summary>
        /// Property linkRecuperaPassword
        /// </summary>
        [DataMember]
        public String linkRecuperaPassword { get; set; } 
        
        
        #endregion
    }
}

