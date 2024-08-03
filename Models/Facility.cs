﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    /// <summary>
    /// The Facility class represents a Facility that belongs to a <see cref="Facility"> Facilility</see>.
    /// </summary>
    [DebuggerDisplay("Facility: {Facility, nq}")]
    [PrimaryKey(nameof(FacilNo))]
    [Table("ESL_Facilities")]
    public class Facility //: IEnumerable
    {
        #region Public Properties


        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Facility No.")]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; }
              
        /// <summary>
        /// Gets or sets the Facility Name [VARCHAR2(40)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false, 40)]
        [DisplayName("Facility")]
        [Column(nameof(FacilName))]
        public string FacilName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Facility Abbreviation [VARCHAR2(5)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false, 6)]
        [DisplayName("Abreviation")]
        [Column(nameof(FacilAbbr))]
        public string FacilAbbr { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Facility Type [VARCHAR2(30)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 30)]
        [DisplayName("Facility Type")]
        [Column(nameof(FacilType))]
        public string FacilType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Sort Order [NUMBER(2)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 2)]
        [DisplayName("Sort Order")]
        [Column(nameof(SortNo))]
        public int? SortNo { get; set; }

        /// <summary>
        /// Gets or sets the Notes [VARCHAR2(400)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the Updated By [VARCHAR2(60)] of the Facility.  UpdatedBy defaults to user
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Update Date [DATE] of the Facility. UpdateTime is default to sysdate
        /// </summary>
        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the Disable [VARCHAR2(15)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 15)]
        [DisplayName("Disable?")]
        [Column(nameof(Disable))]
        public string? Disable { get; set; }

        /// <summary>
        /// Gets or sets the Visible To [VARCHAR2(60)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Visible To")]
        [Column(nameof(VisibleTo))]
        public string? VisibleTo { get; set; }

        /// <summary>
        /// Gets or sets the Facility Full Name [VARCHAR2(60)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Full Name")]
        [Column(nameof(FacilFullName))]
        public string? FacilFullName { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="Employee" /> instances for the facility.
        /// </summary>
        public virtual List<Employee> EmployeeList { get; set; } = new List<Employee>();

        #endregion

    }
}
