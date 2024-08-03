﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilType), nameof(ZoneNo))]
    [Table("ESL_ClearanceZones")]
    public class ClearanceZone
    {

        [DataObjectFieldAttribute(true, true, false, 5)]
        [DisplayName("Facility Type")]
        public string FacilType { get; set; } = string.Empty;

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Zone No.")]
        public int ZoneNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        [Display(Name = "Zone Description")]
        public string? ZoneDescription { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        [Display(Name = "Disable?")]
        public string? Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int? SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DataType(DataType.Date)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }
    }
}