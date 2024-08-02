using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(ClearanceTypeNo))]
    public class ClearanceType
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        public int ClearanceTypeNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 40)]
        public string ClearanceTypeName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string ClearanceTypeAbbr { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? UpdateDate { get; set; }
    }
}