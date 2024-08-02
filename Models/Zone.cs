using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class Zone
    {
        [DataObjectFieldAttribute(false, true, false, 3)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 5)]
        public string FacilType { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Zone No.")]
        public int ZoneNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 200)]
        public string ZoneDescription { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 2)]
        public int SortNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        [DisplayName("Disable?")]
        public string Disable { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }

    }
}