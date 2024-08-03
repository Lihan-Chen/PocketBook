using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo), nameof(LogTypeNo), nameof(EventID), nameof(EventID_RevNo))]
    [NotMapped]
    public class AllEventDetails
    {
        /// <summary>
        /// Gets or sets the facilName of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]
        [Column(nameof(FacilNo))]
        public int FacilNo { get; set; }


        /// <summary>
        /// Gets or sets the logTypeNo of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]
        [Column(nameof(LogTypeNo))]
        public int LogTypeNo { get; set; }

        /// <summary>
        /// Gets or sets the eventID of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 20)]
        [Column(nameof(EventID))]
        public string EventID { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the eventID_RevNo of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]

        [Column(nameof(EventID_RevNo))]
        public int EventID_RevNo { get; set; }

        /// <summary>
        /// Gets or sets the eventHighlight of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 400)]
        public string EventHighlight { get; set; }
    
        /// <summary>
        /// Gets or sets the eventHighlight of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 400)]
        public string EventTrail { get; set; }

        public virtual AllEvent AllEvent { get; set; }
  }
}