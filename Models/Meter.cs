using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo), nameof(MeterID))]
    [Table("ESL_Meters")]
    public class Meter
    {
        [DataObjectField(true, true, false, 2)]
        [DisplayName("Facility No.")]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; } 
        
        [DataObjectField(true, true, false, 20)]
        [DisplayName("Meter ID.")]
        [Column(nameof(MeterID))]
        public string MeterID { get; set; } = string.Empty;    

        [DataObjectField(false, false, true, 20)]
        [DisplayName("Meter Type")]
        [Column(nameof(MeterType))]
        public string MeterType { get; set; } = string.Empty;

        [DataObjectField(false, false, true, 2)]
        [DisplayName("Sort No.")]
        [Column(nameof(SortNo))]
        public int? SortNo { get; set; }

        [DataObjectField(false, false, true, 400)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        [DataObjectField(false, false, true, 30)]
        [DisplayName("Disable?")]
        [Column(nameof(Disable))]
        public string? Disable { get; set; }

        [DataObjectField(false, false, true, 60)]
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string UpdatedBy { get; set; } = string.Empty;

        [DataObjectField(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }
    }
}
