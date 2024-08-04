using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    /// <summary>
    /// The Destination class represents a Destination that belongs to a <see cref="Destination"> Facilility</see>.
    /// </summary>
    [DebuggerDisplay("Destination: {DestinationName, nq}")]
    [NotMapped]
    public class ClearanceDestination //: IEnumerable
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the Destination No [NUMBER(3)] of the Destination.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 3)]
        [DisplayName("Destination No.")]
        public int DestinationNo { get; set; }

        /// <summary>
        /// Gets or sets the Destination Type [VARCHAR2(30)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 30)]
        [DisplayName("Destination Type")]
        public string DestinationType { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the Destination Name [VARCHAR2(40)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 60)]
        [DisplayName("Destination")]
        public string DestinationName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Destination Abbreviation [VARCHAR2(5)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false, 6)]
        [DisplayName("Abreviation")]
        public string DestAbbr { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Destination.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 3)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the Sort Order [NUMBER(2)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 2)]
        [DisplayName("Sort Order")]
        public int? SortNo { get; set; }

        /// <summary>
        /// Gets or sets the Notes [VARCHAR2(400)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 400)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the Updated By [VARCHAR2(60)] of the Destination.  UpdatedBy defaults to user
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Update Date [DATE] of the Destination. UpdateTime is default to sysdate
        /// </summary>
        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the Disable [VARCHAR2(15)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 15)]
        [DisplayName("Disable?")]
        public string? Disable { get; set; }

        /// <summary>
        /// Gets or sets the Visible To [VARCHAR2(60)] of the Destination.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Visible To")]
        public string? VisibleTo { get; set; }

        #endregion
    }
}
