using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class Loc
    {
        // for LocationSelectList with visible to a plant
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Facility")]
        public string FacilName { get; set; }

        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Abreviation")]
        public string FacilAbbr { get; set; }
    }
}