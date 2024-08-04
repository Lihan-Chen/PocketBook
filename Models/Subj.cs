using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{

    [NotMapped]
    public class Subj
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        public int SubjectNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 100)]
        public string SubjectName { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, false, 5)]
        public string FacilType { get; set; } = string.Empty;
    }
}