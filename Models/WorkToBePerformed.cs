using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class WorkToBePerformed
    {
        ///// <summary>
        ///// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        ///// [DataObjectFieldAttribute(key, identity, isNullable]
        ///// </summary>
        //[DataObjectFieldAttribute(true, true, false)]
        //[DisplayName("Facility No.")]
        //public int FacilNo { get; set; }

        [DataObjectFieldAttribute(true, true, false, 5)]
        public string FacilType { get; set; }

        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Work No.")]
        public int WorkNo { get; set; }
        
        [DataObjectFieldAttribute(false, true, false, 200)]
        public string WorkDescription { get; set; }

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