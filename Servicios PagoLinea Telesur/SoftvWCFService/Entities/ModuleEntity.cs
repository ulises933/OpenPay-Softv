﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SoftvWCFService.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.ModuleEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Module entity
    /// File                    : ModuleEntity.cs
    /// Creation date           : 19/09/2015
    /// Creation time           : 03:47 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class ModuleEntity 
    {
        #region Attributes

        /// <summary>
        /// Property IdModule
        /// </summary>
        [DataMember]
        public int? IdModule { get; set; }
        /// <summary>
        /// Property Description
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Property ModulePath
        /// </summary>
        [DataMember]
        public String ModulePath { get; set; }
        /// <summary>
        /// Property ModuleView
        /// </summary>
        [DataMember]
        public String ModuleView { get; set; }
        /// <summary>
        /// Property ParentId
        /// </summary>
        [DataMember]
        public int? ParentId { get; set; }
        /// <summary>
        /// Property SortOrder
        /// </summary>
        [DataMember]
        public int? SortOrder { get; set; }
        /// <summary>
        /// Property OptAdd
        /// </summary>
        [DataMember]
        public bool? OptAdd { get; set; }
        /// <summary>
        /// Property OptSelect
        /// </summary>
        [DataMember]
        public bool? OptSelect { get; set; }
        /// <summary>
        /// Property OptUpdate
        /// </summary>
        [DataMember]
        public bool? OptUpdate { get; set; }
        /// <summary>
        /// Property OptDelete
        /// </summary>
        [DataMember]
        public bool? OptDelete { get; set; }
        [DataMember]
        public PermisoEntity Permiso { get; set; }

        [DataMember]
        public string DisplayName { get; set;  }
        
        [DataMember]
        public String Icono { get; set; }

        [DataMember]
        public String Viewname { get; set; }

        [DataMember]
        public bool? Display { get; set; }


        [DataMember]
        public int tipo { get; set; }


        #endregion
    }
}

