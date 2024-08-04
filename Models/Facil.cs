using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PocketBook.Models
{
    /// <summary>
    /// The Facility class represents a Facility that belongs to a <see cref="Facility"> Facilility</see>.
    /// </summary>
    [DebuggerDisplay("Facility: {Facility, nq}")]
    public class Facil
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the Facility Name [VARCHAR2(40)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Facility")]
        public string FacilName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Facility Abbreviation [VARCHAR2(8)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Abreviation")]
        public string FacilAbbr { get; set; } = string.Empty;

        #endregion

    }
}
