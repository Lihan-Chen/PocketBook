﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    [NotMapped]
    public class Location
    {
        // ONLY FOR FACILNO >= 50
        [DataObjectFieldAttribute(true, true, false)]
        [Range(50, 300)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Facility")]
        public string FacilName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Abreviation")]
        public string FacilAbbr { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Updated By")]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Disable?")]
        public string? Disable { get; set; }
    }
}