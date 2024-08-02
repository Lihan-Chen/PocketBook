using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class RelatedTo
    {
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Log Type No.")]
        public int LogTypeNo { get; set; }

        //CONSTANTNAME  VARCHAR2(20 BYTE)
        [DataObjectFieldAttribute(true, true, false)]
        public string EventID { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        public string RelatedTo_Subject { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? UpdateDate { get; set; }


    }
}