using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models;

/// <summary>
/// The AllEvent record is an immutable class for readonly  represents an AllEvents that belongs to a <see cref="AllEvent"> AllEvent</see>.
/// In EF Core, AllEvents records query should be set to notracking based on CQRS
/// </summary>
[DebuggerDisplay("AllEvent: {FacilName, nq} {LogTypeName, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})

[PrimaryKey(nameof(FacilNo), nameof(LogTypeNo), nameof(EventID), nameof(EventID_RevNo))]
[Table("ESL_AllEvents")]
public record AllEvent // : BusinessBase
{

    #region Private Variables

    // constants have all being moved into the constants namespace and decorated as public static readonly 
    private static string _CrLf = "<br />"; // System.Environment.NewLine;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the facilName of the AllEvents.
    /// </summary>
    [DataObjectField(true, true, false, 2)]
    [Column("FacilNo")]
    public int FacilNo { get; set; }

    /// <summary>
    /// Gets or sets the facilName of the AllEvents.
    /// </summary>
    /// 
    [DataObjectField(false, false, false, 40)]
    
    [NotMapped]
    public string FacilName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the facilAbbr of the AllEvents.
    /// </summary>
    /// 
    [DataObjectField(false, false, false, 5)]
    [NotMapped]
    public string FacilAbbr { get; set; } = string.Empty;


    /// <summary>
    /// Gets or sets the logTypeNo of the AllEvents.
    /// </summary>
    [DataObjectField(true, true, false, 2)]
    
    [Column("LogTypeNo")]
    public int LogTypeNo { get; set; }

    /// <summary>
    /// Gets or sets the logTypeName of the AllEvents.
    /// </summary>
    /// 
    [DataObjectField(false, false, false, 100)]
    [NotMapped]
    public string LogTypeName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the eventID of the AllEvents.
    /// </summary>
    [DataObjectField(true, true, false, 20)]
    [Column("EventID")]
    public string EventID { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the eventID_RevNo of the AllEvents.
    /// </summary>
    [DataObjectField(true, true, false, 2)]

    [Column("EventID_RevNo")]
    public int EventID_RevNo { get; set; }

    /// <summary>
    /// Gets or sets the eventDate of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false)]
    [Column("EventDate")]
    public DateTime? EventDate { get; set; }

    /// <summary>
    /// Gets or sets the eventTime of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 5)]
    [Column("EventTime")]
    public string EventTime { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the subject of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 300)]
    [Column("Subject")]
    public string Subject { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the details of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 2000)]
    //[NotNullOrEmpty(Key = "DetailsNotEmpty")]

    [Column("Details")] 
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the modifyFlag of the FlowChange.
    /// </summary>
    [DataObjectField(false, false, true, 100)]
    [Column("ModifyFlag")]
    public string? ModifyFlag { get; set; }

    /// <summary>
    /// Gets or sets the notes of the FlowChange.
    /// </summary>
    [DataObjectField(false, false, true, 400)]
    [Column("Notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Gets or sets the operatorType of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 15)]
    //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
    [Column("OperatorType")]
    public string? OperatorType { get; set; }

    /// <summary>
    /// Gets or sets the updatedBy uID of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 60)]
    [Column("UpdatedBy")]
    public string UpdatedBy { get; set; } = string.Empty;

    ///// <summary>
    ///// Gets or sets the updatedBy of the AllEvents.
    ///// </summary>
    //[DataObjectField(false, false, false)]
    //public string UpdatedByName { get; set; }

    /// <summary>
    /// Gets or sets the updateDate of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false)]
    [Column("UpdateDate")]
    public DateTimeOffset UpdateDate { get; set; }

    /// <summary>
    /// Gets or sets the clearanceID of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, false, 20)]
    //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
    [Column("ClearanceID")]
    public string? ClearanceID { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ScanDocsNo of the AllEvents.
    /// </summary>
    [DataObjectField(false, false, true, 2)]
    [NotMapped]
    public int ScanDocsNo { get; set; }

    /// <summary>
    /// Gets or sets the eventIdentifier of the AllEvents.
    /// </summary>
    //[DataObjectField(false, false, false)]
    //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
    [NotMapped]
    public string EventIdentifier => $"{EventID}/{EventID_RevNo.ToString()}";

    /// <summary>
    /// Gets or sets the eventHighlight of the AllEvents.
    /// </summary>
    //[DataObjectField(false, false, false)]
    //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
    [NotMapped]
    public string EventHighlight => Subject ?? Subject + _CrLf + (Details ?? (Details + _CrLf) + "Updated By: " + UpdatedBy + " on " + UpdateDate);

    //// Navigation to be implemented with EF virtural
    //public virtual ScanDoc? scandoc { get; set; }

    #endregion
}
