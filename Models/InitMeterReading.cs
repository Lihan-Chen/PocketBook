using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class InitMeterReading
    {
        /// <summary>
        /// Gets or sets the facilName of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Facil. No.")]
        public int FacilNo { get; set; }
        
        /// <summary>
        /// Gets or sets the meterID of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false,false,false, 30)]
        [Required(ErrorMessage = "Meter ID is missing.  Please select fromt the pull-down.")]
        [Display(Name = "Meter ID")]
        public string MeterID { get; set; }

        /// <summary>
        /// Gets or sets the oldValue of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 10)]
        [Display(Name = "Old Value")]
        public decimal? OldValue { get; set; }

        /// <summary>
        /// Gets or sets the oldUnit of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 10)]
        [Required(ErrorMessage = "All unit must be consistent.")]
        [Display(Name = "Old Unit")]
        public string OldUnit { get; set; }
    }
}

        

 