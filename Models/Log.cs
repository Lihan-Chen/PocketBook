using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace PocketBook.Models
{
    /// <summary>
    /// The Log class represents an LogType that belongs to a <see cref="Log"> Log</see>.
    /// </summary>
    [
      DebuggerDisplay("Logtype: {LogTypeName, nq}")
    ]
    public class Log
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the logTypeNo of the LogTypes.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Log Type No.")]
        public int LogTypeNo { get; set; }

        /// <summary>
        /// Gets or sets the logTypeName of the LogTypes.
        /// </summary>
        [DataObjectFieldAttribute(false, true, false)]
        [DisplayName("Log Type Name")]
        public string LogTypeName { get; set; }

        #endregion
    }
}
