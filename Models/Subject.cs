using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class Subject
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        public int SubjectNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 100)]
        public string SubjectName { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string FacilType { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int? SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        public string Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? UpdateDate { get; set; }
    }
}