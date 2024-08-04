using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo),nameof(ShiftNo))]
    public class PlantShift
    {
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Shift No.")]
        public int ShiftNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 20)]
        public string? ShiftName { get; set; }

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string ShiftStart { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, true, false, 5)]
        public string ShiftEnd { get; set; } = string.Empty;

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? UpdateDate { get; set; }


    }
}