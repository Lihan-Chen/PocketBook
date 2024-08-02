using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    /// <summary>
    /// The RealTime class represents a prescheduled flowchange event that belongs to a <see cref="RealTime"> RealTime</see>.
    /// LogTypeNo = 5 for FlowChange
    /// </summary>
    [DebuggerDisplay("RealTime: {FacilNo, nq} {LogTypeNo, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})
    public class RealTime 
    {

        #region Public Properties

        /// <summary>
        /// Gets or sets the facilName of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
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
        [DataObjectFieldAttribute(true, true, false, 2)]
        public int EventID_RevNo { get; set; }

        /// <summary>
        /// Gets or sets the eventDate of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Gets or sets the subject of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 300)]
        public string Subject { get; set; }

        #endregion

    }
}