﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.Reportes_PlantaEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Reportes_Planta entity
    /// File                    : Reportes_PlantaEntity.cs
    /// Creation date           : 09/03/2017
    /// Creation time           : 03:21 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class Ecom_PagoEnLineaEntity 
    {
        #region Attributes


        /// <summary>
        /// Property Suscriptor
        /// </summary>
        [DataMember]
        public String Contrato { get; set; }



        #endregion
    }

    [DataContract]
    [Serializable]
    public class ResultadoPagoLineaEntity
    {
        #region Attributes


        /// <summary>
        /// Property Suscriptor
        /// </summary>
        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Valor { get; set; }

        #endregion
    }

    [DataContract]
    [Serializable]
    public class YaHuboPagoEntity
    {
        #region Attributes


        /// <summary>
        /// Property Suscriptor
        /// </summary>
        [DataMember]
        public int Pasa { get; set; }

        [DataMember]
        public long Clv_Session { get; set; }

        #endregion
    }
}

