using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class PlantShift
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Shift No.")]
        public int ShiftNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 20)]
        public string ShiftName { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string ShiftStart { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string ShiftEnd { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? UpdateDate { get; set; }


    }
}