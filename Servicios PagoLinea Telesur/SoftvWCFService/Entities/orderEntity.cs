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
    public class orderEntity 
    {
        #region Attributes
               
        /// <summary>
        /// Property id
        /// </summary>
        [DataMember]
        public String id { get; set; }
        /// <summary>
        /// Property amount
        /// </summary>
        [DataMember]
        public String amount { get; set; }
        /// <summary>
        /// Property currency
        /// </summary>
        [DataMember]
        public String currency { get; set; }
        
        #endregion
    }
}

