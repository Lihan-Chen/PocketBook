using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PocketBook.Models
{
    [PrimaryKey(nameof(FacilNo), nameof(ConstantName), nameof(StartDate))]
    public class Constant
    {

        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 20)]
        [DisplayName("Constant")]
        public string ConstantName { get; set; }

        [DataObjectFieldAttribute(true, true, false)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Start")]
        public DateTime StartDate { get; set; }
        
        //ENDDATE       DATE
        [DataObjectFieldAttribute(false, false, true)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "End")]
        public DateTime? EndDate { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Value")]
        public int? Value { get; set; }

        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Comment")]
        public string? Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        public string? UpdatedBy { get; set; } 

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }
    }
}