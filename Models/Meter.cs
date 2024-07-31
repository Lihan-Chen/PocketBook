﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(MeterID))]
    public class Meter
    {
        [DataObjectField(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectField(true, true, false, 20)]
        [DisplayName("Meter ID.")]
        public string MeterID { get; set; } = string.Empty;

        [DataObjectField(false, false, true, 20)]
        public string MeterType { get; set; } = string.Empty;

        [DataObjectField(false, false, true, 2)]
        public int? SortNo { get; set; }

        [DataObjectField(false, false, true, 400)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DataObjectField(false, false, true, 30)]
        public string? Disable { get; set; }

        [DataObjectField(false, false, true, 60)]
        public string UpdatedBy { get; set; } = string.Empty;

        [DataObjectField(false, false, true)]
        public DateTime? UpdateDate { get; set; }
    }
}
