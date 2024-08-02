using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace PocketBook.Models
{
    /// <summary>
    /// The Report class represents an event for a type of log that belongs to a <see cref="AllEvent"> AllEvent</see>.
    /// </summary>
    [DebuggerDisplay("Event: {FacilName, nq} {LogTypeName, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})
    public class Rpt
    {
        #region Internal Variables

        internal string _CrLf = "<br />"; // Environment.NewLine ; // "\\r?\\n"; "<br />"; "\r\n";

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the facilName of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Facil. No.")]
        public int FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the facilName of the FlowChange.
        /// </summary>
        /// 
        [DataObjectFieldAttribute(false, false, false, 40)]
        [Display(Name = "Facility")]
        public string FacilName { get; set; }

        /// <summary>
        /// Gets or sets the logTypeNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Log Type No.")]
        public int LogTypeNo { get; set; }

        /// <summary>
        /// Gets or sets the logTypeName of the FlowChange.
        /// </summary>
        /// 
        [DataObjectFieldAttribute(false, false, false, 100)]
        [Display(Name = "Log Type")]
        public string LogTypeName { get; set; }

        /// <summary>
        /// Gets or sets the eventID of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 20)]
        [Display(Name = "Event ID")]
        public string EventID { get; set; }

        /// <summary>
        /// Gets or sets the eventID_RevNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Revision No.")]
        public int EventID_RevNo { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the modifyFlag of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 5)]
        [Display(Name = "Event Time")]
        public string EventTime { get; set; }


        /// <summary>
        /// Gets or sets the notifiedPerson of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 120)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
       
        /// <summary>
        /// Gets or sets the eventSubject of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 2000)]
        [Display(Name = "Details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the eventDetails of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 60)]
        [Display(Name = "Updated By")]
        public string UpdatedByName { get; set; }

        /// <summary>
        /// Gets or sets the updateDate of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        public DateTime UpdateDate { get; set; }

        #endregion
    }
}
