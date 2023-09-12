﻿
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.MuestraBancosEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : MuestraBancos entity
    /// File                    : MuestraBancosEntity.cs
    /// Creation date           : 27/10/2016
    /// Creation time           : 01:39 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class MuestraBancosEntity 
    {
    #region Attributes
    
      /// <summary>
      /// Property Clave
      /// </summary>
      [DataMember]
      public int? Clave { get; set; }
      /// <summary>
      /// Property nombre
      /// </summary>
      [DataMember]
      public String nombre { get; set; }
    #endregion
    }
    }

  