using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace PocketBook.Models
{
  /// <summary>
  /// The LogType class represents an LogType that belongs to a <see cref="LogType"> LogType</see>.
  /// </summary>
  [
    DebuggerDisplay("Logtype: {LogTypeName, nq}")
  ]
  public class LogType
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the logTypeNo of the LogTypes.
    /// </summary>
    [DataObjectFieldAttribute(true, true, false, 2)]
    [DisplayName("Log Type No.")]
    public int LogTypeNo { get; set; }
    
    /// <summary>
    /// Gets or sets the logTypeName of the LogTypes.
    /// </summary>
    [DataObjectFieldAttribute(false, true, false, 100)]
    [DisplayName("Log Type Name")]
    public string LogTypeName { get; set; }

    /// <summary>
    /// Gets or sets the Notes [VARCHAR2(400)] of the Employee.
    /// </summary>
    [DataObjectFieldAttribute(false, false, true, 400)]
    [DisplayName("Notes")]
    public string Notes { get; set; }

    [DataObjectFieldAttribute(false, false, true, 60)]
    [DisplayName("Updated By")]
    public string UpdatedBy { get; set; }

    [DataObjectFieldAttribute(false, false, true)]
    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get; set; }
    #endregion

  }
}
