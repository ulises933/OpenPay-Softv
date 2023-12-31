﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.PermisoEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Permiso entity
    /// File                    : PermisoEntity.cs
    /// Creation date           : 12/12/2014
    /// Creation time           : 17:54
    ///</summary>
    [DataContract]
    [Serializable]
    public class PermisoEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdRol
        /// </summary>
        [DataMember]
        public int? IdRol { get; set; }
        /// <summary>
        /// Property IdModule
        /// </summary>
        [DataMember]
        public int? IdModule { get; set; }
        /// <summary>
        /// Property OptAdd
        /// </summary>
        [DataMember]
        public bool OptAdd { get; set; }
        /// <summary>
        /// Property OptSelect
        /// </summary>
        [DataMember]
        public bool OptSelect { get; set; }
        /// <summary>
        /// Property OptUpdate
        /// </summary>
        [DataMember]
        public bool OptUpdate { get; set; }
        /// <summary>
        /// Property OptDelete
        /// </summary>
        [DataMember]
        public bool OptDelete { get; set; }

        [DataMember]
        public ModuleEntity Module { get; set; }

        [DataMember]
        public RoleEntity Role { get; set; }

        #endregion
    }
}

