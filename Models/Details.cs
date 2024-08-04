﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
   
    [PrimaryKey(nameof(FacilNo), nameof(DetailsNo))]
    [Table("ESL_Details")]
    public class Details
    {
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Facility No.")]
        [ForeignKey(nameof(Subject))]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Details No.")]
        [Column(nameof(DetailsNo))]
        public int DetailsNo { get; set; }
        
        [DataObjectFieldAttribute(false, true, false, 100)]
        [DisplayName("Detail Name")]
        [Column(nameof(DetailsName))]
        public string DetailsName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false, 5)]
        [Column(nameof(FacilType))]
        public string FacilType { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 2)]
        [Column(nameof(SortNo))]
        public int? SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        [ForeignKey(nameof(Subject))]
        [Column("SubjNo")]
        public int? SubjectRefNo { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Subject")]
        [NotMapped]
        public string SubjectName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 30)]
        [Column(nameof(Disable))]
        public string? Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]        
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }

        Subject Subject { get; set; } = new Subject();
    }
}