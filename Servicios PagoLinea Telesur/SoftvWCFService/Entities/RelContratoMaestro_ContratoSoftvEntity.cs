﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.RelContratoMaestro_ContratoSoftvEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : RelContratoMaestro_ContratoSoftv entity
    /// File                    : RelContratoMaestro_ContratoSoftvEntity.cs
    /// Creation date           : 23/02/2017
    /// Creation time           : 11:27 a. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class RelContratoMaestro_ContratoSoftvEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdContratoMaestro
        /// </summary>
        [DataMember]
        public long? IdContratoMaestro { get; set; }
        /// <summary>
        /// Property Contrato
        /// </summary>
        [DataMember]
        public long? Contrato { get; set; }



        [DataMember]
        public int? Nivel { get; set; }

        [DataMember]
        public bool? Proporcional { get; set; }


        #endregion
    }
}

