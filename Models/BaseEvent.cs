﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PocketBook.Models.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketBook.Models
{
    /// <summary>
    /// The BaseEvent class represents an event for a type of log that belongs to a <see cref="FlowChange"> AllEvent</see>.
    /// </summary>
    [DebuggerDisplay("Event: {FacilName, nq} {LogTypeName, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})
    [PrimaryKey(nameof(FacilNo), nameof(LogTypeNo), nameof(EventID), nameof(EventID_RevNo))]
    public abstract class BaseEvent
    {
        #region Internal Variables

        internal string _CrLf = "<br />"; // Environment.NewLine ; // "\\r?\\n"; "<br />"; "\r\n";

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the facilName of the event.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Facil. No.")]
        [Column("FacilNo")] 
        public int FacilNo  { get; set; }
        
        /// <summary>
        /// Gets or sets the facilName of the event.
        /// </summary>
        /// 
        [DataObjectFieldAttribute(false, false, false)]
        [Display(Name = "Facility")]
        [NotMapped]
        public string FacilName  { get; set; } = string.Empty;
        
        /// <summary>
        /// Gets or sets the logTypeNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Log Type No.")]
        [Column("LogTypeNo")]
        public int LogTypeNo  { get; set; }

        /// <summary>
        /// Gets or sets the logTypeName of the FlowChange.
        /// </summary>
        /// 
        [DataObjectFieldAttribute(false, false, false)]
        [Display(Name = "Log Type")]
        [NotMapped]
        public string LogTypeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the eventID of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 20)]
        [Display(Name = "Event ID")]
        [Column("EventID")]
        public string EventID { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the eventID_RevNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [Display(Name = "Revision No.")]
        [Column("EventID_RevNo")]
        public int EventID_RevNo { get; set; }

        /// <summary>
        /// Gets or sets the operatorID of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 7)]
        [Display(Name = "Operator")]
        [Required(ErrorMessage="Need to select a name from pull-down list.  Please try again.")]
        [Column("OperatorID")]
        public int OperatorID { get; set; }

        /// <summary>
        /// Gets or sets the createdBy of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 7)]
        //[Display(Name = "Created By")]
        //[Required(ErrorMessage = "Need to select a name from pull-down list.  Please try again.")]
        [Column("CreateBy")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the createdDate of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        [Display(Name = "Created Date")]
        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }
        
        /// <summary>
        /// Gets or sets the modifyFlag of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [Display(Name = "Modify Flag")]
        [Column("ModifyFlag")]
        public string? ModifyFlag { get; set; }
        
        /// <summary>
        /// Gets or sets the modifiedBy of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 7)]
        [Display(Name = "Modified By")]
        [Column("ModifiedBy")]
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the modifyDate of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true)]
        [Display(Name = "Date Modified")]
        [Column("ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the notes of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 400)]
        [Display(Name = "Notes")]
        [Column("Notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the notifiedFacil of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 200)]
        [Display(Name = "Notified Facility")]
        [Column("NotifiedFacil")]
        public string? NotifiedFacil { get; set; }

        /// <summary>
        /// Gets or sets the notifiedPerson of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 7)]
        // [Display(Name = "Notified Person (optional)")]
        [Column("NotifiedPerson")]
        public int? NotifiedPerson { get; set; }

        /// <summary>
        /// Gets or sets the notifiedPerson of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 80)]
        [Display(Name = "Notified Person (optional)")]
        public string? NotifiedPerson_Name => Helpers.GetEmpFullName("NotifiedPerson", NotifiedPerson, FacilNo);
        
        /// <summary>
        /// Gets or sets the shiftNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 2)]
        [Display(Name = "Shift No")]
        public int? ShiftNo { get; set; }
        /// <summary>
        /// Gets or sets the yr of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 2)]
        //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
        //[RegularExpression("^d{2}$", ErrorMessage = "Please enter YY format.")]
        [Display(Name = "Year")]
        [Column("Yr")]
        public string Yr { get; set; } = DateTime.Now.Year.ToString();

        /// <summary>
        /// Gets or sets the seqNo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 6)]
        [Display(Name = "Sequence No.")]
        [Column("SeqNo")]
        public int SeqNo { get; set; }

        /// <summary>
        /// Gets or sets the updatedBy of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 60)]
        [Display(Name = "Updated By")]
        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the updateDate of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        [Column("UpdateDate")]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the workOrders of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [Display(Name = "Work Orders")]
        [Column("WorkOrders")]
        public string? WorkOrders { get; set; }

        /// <summary>
        /// Gets or sets the relatedTo of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 200)]
        [Display(Name = "Related To")]
        [Column("RelatedTo")]
        public string? RelatedTo { get; set; }
        
        /// <summary>
        /// Gets or sets the operatorType of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 15)]
        [Display(Name = "Operator Type (Optional)")]
        [Column("OperatoryType")]
        public string? OperatorType { get; set; }

        /// <summary>
        /// Gets or sets the ScanDocsNo of the AllEvents.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 2)]
        public int ScanDocsNo { get; set; }


        ///// <summary>
        ///// Gets or sets the eventSubject of the FlowChange.
        ///// </summary>
        //[DataObjectFieldAttribute(false, false, false)]
        //[Display(Name = "Subject")]
        //[NotMapped]
        //public string EventSubject { get; set; }

        ///// <summary>
        ///// Gets or sets the eventDetails of the FlowChange.
        ///// </summary>
        //[DataObjectFieldAttribute(false, false, false)]
        //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
        //[Display(Name = "Details")]
        //[NotMapped]
        //public string? EventDetails { get; set; }

        

        #endregion
    }
}
