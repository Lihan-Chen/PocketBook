using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    /// <summary>
    /// The ClearanceIssues class represents an ClearanceIssues that belongs to a <see cref="ClearanceIssue"> ClearanceIssues</see>.
    /// </summary>
    [DebuggerDisplay("ClearanceIssues : {FacilName, nq} {LogTypeName, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})
    [Table("ESL_ClearanceIssue")]
    public class ClearanceIssue : BaseEvent
    {

        #region Private Variables

        //private string _CrLf = "<br />"; // Environment.NewLine ; // "\\r?\\n"; "<br />"; "\r\n";

        #endregion

        #region Public Properties

        [DataObjectFieldAttribute(false, false, true)]
        public string Operator { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public string Creator { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 7)]
        public int IssuedTo { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 7)]
        public int IssuedBy { get; set; }
        
        /// <summary>
        /// Gets or sets the issuedDate of the ClearanceIssues .
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        public DateTime IssuedDate { get; set; }
        
       /// <summary>
        /// Gets or sets the eventTime of the ClearanceIssues .
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 5)]
        public string IssuedTime { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 6)]
        public string FacilAbbr { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 2)]
        public string ClearanceType { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 300)]
        public string ClearanceZone { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 200)]
        public string Location { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 600)]
        public string WorkToBePerformed { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 200)]
        public string EquipmentInvolved { get; set; }
                
        [DataObjectFieldAttribute(false, false, true, 7)]
        public int? ReleasedTo { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 7)]
        public int? ReleasedBy { get; set; }
        
        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? ReleasedDate { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 5)]
        public string ReleasedTime { get; set; }

        [DataObjectFieldAttribute(false, false, true, 30)]
        public string ReleaseType { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 200)]
        public string TagsRemoved { get; set; }
        
        [DataObjectFieldAttribute(false, false, true, 20)]
        public string ClearanceID { get; set; }

        /// <summary>
        /// Gets or sets the eventIdentifier of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        [NotMapped]
        public string EventIdentifier
        {
            get
            {
                return ClearanceID + " / " + Convert.ToString(EventID_RevNo);
            }

        }

        /// <summary>
        /// Gets or sets the eventHighlight of the FlowChange.
        /// </summary>
        [NotMapped]
        public string EventHighlight
        {
            get
            {
                string _EventHighlight = String.Empty;
                if (!String.IsNullOrEmpty(Location))
                {
                    _EventHighlight = "Location: " + Location + _CrLf;
                }

                if (!String.IsNullOrEmpty(ClearanceZone))
                {
                    _EventHighlight += "Clearance Area: " + ClearanceZone + _CrLf;
                }

                if (!String.IsNullOrEmpty(WorkToBePerformed))
                {
                    _EventHighlight += "Work to be performed: " + WorkToBePerformed + _CrLf;
                }

                if (!String.IsNullOrEmpty(EquipmentInvolved))
                {
                    _EventHighlight += "Equipment involved: " + EquipmentInvolved + _CrLf;
                }

                if (!String.IsNullOrEmpty(RelatedTo))
                {
                    _EventHighlight += "Related to Event Nos.: " + RelatedTo + _CrLf;
                }

                if (!String.IsNullOrEmpty(WorkOrders))
                {
                    _EventHighlight += "Work Order Nos.: " + WorkOrders + _CrLf;
                }

                if (!String.IsNullOrEmpty(Notes))
                {
                    _EventHighlight += "Additional Notes: " + Notes + _CrLf;
                }

                if (!String.IsNullOrEmpty(ReleaseType))
                {
                    _EventHighlight += "Tags removed: " + TagsRemoved + _CrLf;
                }

                _EventHighlight += "Scanned docs stored: " + ScanDocsNo;

                return _EventHighlight;
            }
        }

        // need to add "Scanned Docs Stored: " (scandocs.count) when scanned docs directory are established on servers, or just ignore for now.

        /// <summary>
        /// Gets or sets the eventTrail of the FlowChange.
        /// </summary>
        
        [NotMapped]
        public string EventTrail
        {
            get
            {
                string _EventTrail = String.Empty;
                string _ReleasedBy = String.Empty;
                string _ReleasedTo = String.Empty;

                _EventTrail = "Issued to: " + Helpers.GetEmpFullName("IssuedTo", IssuedTo, FacilNo) + _CrLf;

                _EventTrail += "Issued by: " + Helpers.GetEmpFullName("IssuedBy", IssuedBy, FacilNo) + _CrLf;

                 if (IssuedDate != DateTime.MinValue)
                {
                    _EventTrail += "Requested Dt/Tm: " + IssuedDate.ToString("MM/dd/yyyy") + " " + IssuedTime + _CrLf;
                }

                _ReleasedBy = ReleasedBy.HasValue ? Helpers.GetEmpFullName("ReleasedBy", ReleasedBy.Value, FacilNo) : "n/a";

                _ReleasedTo = ReleasedBy.HasValue ? Helpers.GetEmpFullName("ReleasedBy", ReleasedTo.Value, FacilNo) : "n/a";
                 
                
                switch (ReleaseType)
                {
                    case "Full Release": _EventTrail += "Full Released by: " + _ReleasedBy + _CrLf + "Full Released to: " + _ReleasedTo + _CrLf;
                                         _EventTrail += "Full Released Dt/Tm: " + (ReleasedDate.HasValue ? ReleasedDate.Value.ToString("MM/dd/yyyy") : "n/a") + " " + ReleasedTime + _CrLf;
                        break;
                    case "Test Release": _EventTrail += "Test Released by: " + _ReleasedBy + _CrLf + "Test Released to: " + _ReleasedTo + _CrLf;
                                         _EventTrail += "Test Released Dt/Tm: " + (ReleasedDate.HasValue ? ReleasedDate.Value.ToString("MM/dd/yyyy") : "n/a") + " " + ReleasedTime + _CrLf;
                        break;
                    case "Transfer": _EventTrail += "Released by: " + _ReleasedBy + _CrLf + "Released to: " + _ReleasedTo + _CrLf;
                        _EventTrail += "Released Dt/Tm: " + (ReleasedDate.HasValue ? ReleasedDate.Value.ToString("MM/dd/yyyy") : "n/a") + " " + ReleasedTime + _CrLf;
                                     //_EventTrail = "Transferred to: " + IssuedTo.ToString() + _CrLf + "Relased by: " + IssuedTo.ToString() + _CrLf;
                                     //_EventTrail += "Transferred Dt/Tm: " + IssuedDate.ToString("MM/dd/yyyy") + " " + IssuedTime + _CrLf;
                        break;
                }

                if (!String.IsNullOrEmpty(OperatorID.ToString()))
                                {
                                    _EventTrail += "Logged By: " + Helpers.GetEmpFullName("LoggedBy", OperatorID, FacilNo) + _CrLf;
                                    _EventTrail += "Logged Dt/Tm: " + UpdateDate.ToString("MM/dd/yyyy hh:mm") + _CrLf;
                                }
                //if (!String.IsNullOrEmpty(NotifiedPerson))
                if (!String.IsNullOrEmpty(NotifiedPerson.ToString()))
                {
                    _EventTrail += "Notified Person: " + Helpers.GetEmpFullName("Notified", NotifiedPerson.Value, FacilNo) + _CrLf;
                }

                return _EventTrail;
            }
        }

        #endregion

    }
}
