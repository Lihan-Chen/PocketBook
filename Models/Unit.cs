using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{

    [PrimaryKey(nameof(UnitNo))]
    [Table("ESL_Units")]
    public class Unit
    {
        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Unit No.")]
        [Column(nameof(UnitNo))]
        public int UnitNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 20)]
        [Column(nameof(UnitName))]
        public string? UnitName { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        [Column(nameof(UnitDesc))]
        public string? UnitDesc { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 80)]
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string? UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTime? UpdateDate { get; set; }
    }
}