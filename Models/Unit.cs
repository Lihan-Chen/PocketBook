using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class Unit
    {
        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [DisplayName("Unit No.")]
        public int UnitNo { get; set; }

        [DataObjectFieldAttribute(false, false, true, 20)]
        public string UnitName { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        public string UnitDesc { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true, 80)]
        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }
    }
}