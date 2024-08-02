using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class WorkOrder
    {
        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        public int LogTypeNo { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        public string EventID { get; set; }
    
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Work Order No.")]
        public string WO_No { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }
    }
}