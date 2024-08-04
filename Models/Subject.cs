using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo), nameof(SubjectNo))]
    [Table("ESL_Subjects")]
    public class Subject
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("subject No.")]
        [Column("SubjNo")]
        public int SubjectNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 100)]
        [DisplayName("subject")]
        [Column("SubjName")]
        public string SubjectName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false, 5)]
        [DisplayName("Facility Type")]
        [Column(nameof(FacilType))]
        public string FacilType { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 2)]
        [DisplayName("Sort No.")]
        [Column(nameof(SortNo))]
        public int? SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

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

        //[ForeignKey(nameof(FacilNo), nameof(Details.SubjectNo))]
        public ICollection<Details> DetailsList { get; } = new List<Details>();
    }
}