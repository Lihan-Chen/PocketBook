using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class EquipmentInvolved
    {
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        [DisplayName("Facility Type")]
        public string FacilType { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Equipment No.")]
        public int EquipNo { get; set; }

        [DataObjectFieldAttribute(false, true, false, 100)]
        [DisplayName("Equipment")]
        public string EquipName { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

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