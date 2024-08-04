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
    [PrimaryKey(nameof(FacilNo),nameof(LogTypeNo),nameof(EventID),nameof(WO_No))]
    [Table("ESL_WorkOrders")]
    public class WorkOrder
    {
        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Facility No.")]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        [Column(nameof(LogTypeNo))]
        public int LogTypeNo { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        [Column(nameof(EventID))]
        public string EventID { get; set; } = string.Empty;
    
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Work Order No.")]
        [Column(nameof(WO_No))]
        public string WO_No { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }
    }
}