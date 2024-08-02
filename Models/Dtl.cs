using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo), nameof(DetailsNo))]
    public class Dtl
    {
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Details No.")]
        public int DetailsNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 100)]
        public string DetailsName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string FacilType { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int? SubjectNo { get; set; }

        //[DataObjectFieldAttribute(false, false, true)]
        //[DisplayName("Subject")]
        //public string SubjectName { get; set; }
    }
}