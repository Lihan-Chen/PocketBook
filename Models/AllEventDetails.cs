using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class AllEventDetails
    {
        /// <summary>
        /// Gets or sets the facilName of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(true,true,false, 2)]
        public int FacilNo { get; set; }
       
        /// <summary>
        /// Gets or sets the logTypeNo of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        public int LogTypeNo { get; set; }
            
        /// <summary>
        /// Gets or sets the eventID of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 20)]
        public string EventID { get; set; }
    
        /// <summary>
        /// Gets or sets the eventID_RevNo of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(true,true,false, 2)]
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