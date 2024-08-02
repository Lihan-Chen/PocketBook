using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class Details
    {
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Details No.")]
        public int DetailsNo { get; set; }
        
        [DataObjectFieldAttribute(false, true, false, 100)]
        [DisplayName("Detail Name")]
        public string DetailsName { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string FacilType { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int? SubjectNo { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        public string Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]

        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }

        
    }
}