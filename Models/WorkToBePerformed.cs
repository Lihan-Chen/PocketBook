using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(WorkNo))]
    [Table("ESL_WorkToBePerformed")]
    public class WorkToBePerformed
    {
        ///// <summary>
        ///// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        ///// [DataObjectFieldAttribute(key, identity, isNullable]
        ///// </summary>
        //[DataObjectFieldAttribute(true, true, false)]
        //[DisplayName("Facility No.")]
        //public int FacilNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        [DisplayName("Facility Type")]
        [Column(nameof(FacilType))]
        public string FacilType { get; set; } = string.Empty;

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Work No.")]
        [Column(nameof(WorkNo))]
        public int WorkNo { get; set; }
        
        [DataObjectFieldAttribute(false, true, false, 200)]
        [Column(nameof(WorkDescription))]
        public string WorkDescription { get; set; } = string.Empty;
       
        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        [DisplayName("Sort No.")]
        [Column(nameof(SortNo))]
        public int? SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        [DisplayName(nameof(Disable))]
        [Column(nameof(Disable))]
        public string? Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName(nameof(UpdatedBy))]
        [Column(nameof(UpdatedBy))]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName(nameof(UpdateDate))]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }

    }
}