using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;
using PocketBook.Models.Dal;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    /// <summary>
    /// The FlowChange class represents an FlowChange that belongs to a <see cref="AllEvent"> AllEvent</see>.
    /// </summary>
    public class SOC : BaseEvent
    {

        #region Private Variables

        //private string _CrLf = "<br />"; // Environment.NewLine ; // "\\r?\\n"; "<br />"; "\r\n";

        #endregion

        #region Public Properties

        [DataObjectFieldAttribute(false, false, true, 7)]
        public int? ReportedBy { get; set; }

        [DataObjectFieldAttribute(false, false, false, 7)]
        public int? ReportedTo { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ReportedDate { get; set; }

        [DataObjectFieldAttribute(false, false, true, 5)]
        public string ReportedTime { get; set; }

        [DataObjectFieldAttribute(false, false, true, 7)]
        public int? ReleasedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true, 7)]
        public int? ReleasedTo { get; set; }
        
        [DataObjectFieldAttribute(false, false, true)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime?  ReleasedDate { get; set; }

        [DataObjectFieldAttribute(false, false, true, 5)]
        public string ReleasedTime { get; set; }

        [DataObjectFieldAttribute(false, false, true, 100)]
        public string ReleaseType { get; set; }

        [DataObjectFieldAttribute(false, false, false, 5)]
        public string FacilAbbr { get; set; }

        [DataObjectFieldAttribute(false, false, false, 200)]
        public string Location { get; set; }

        //[DataObjectFieldAttribute(false, false, false, 300)]
        //public string ClearanceZone { get; set; }

        [DataObjectFieldAttribute(false, false, false, 600)]
        public string Limitations { get; set; }

        //[DataObjectFieldAttribute(false, false, true, 600)]
        //public string WorkToBePerformed { get; set; }

        [DataObjectFieldAttribute(false, false, true, 200)]
        public string EquipmentInvolved { get; set; }

        //[DataObjectFieldAttribute(false, false, true)]
        //public string TagsInstalled { get; set; }

        [DataObjectFieldAttribute(false, false, true, 100)]
        public string TagsInstalled { get; set; }

        /// <summary>
        /// Gets or sets the eventIdentifier of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        //[NotNullOrEmpty(Key = "DetailsNotEmpty")]
        public string EventIdentifier
        {
            get
            {
                return EventID + " / " + Convert.ToString(EventID_RevNo);
            }

        }

        /// <summary>
        /// Gets or sets the eventHighlight of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        //[NotNullOrEmpty(Key = "DetailsNotEmpty")
        public string EventHighlight
        {
            get
            {
                string _EventHighlight = String.Empty;

                _EventHighlight = "Location: " + Location + _CrLf;

                if (!String.IsNullOrEmpty(RelatedTo))
                {
                    _EventHighlight += "Related to Event Nos.: " + RelatedTo + _CrLf;
                }
                
                if (!String.IsNullOrEmpty(EquipmentInvolved))
                {
                    _EventHighlight = "Equipment involved: " + EquipmentInvolved + _CrLf;
                }

                if (!String.IsNullOrEmpty(Limitations))
                {
                    _EventHighlight = "Limitations: " + Limitations + _CrLf;
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
                    _EventHighlight += "Tags removed: " + TagsInstalled + _CrLf;
                }

                _EventHighlight += "Scanned docs stored: " + ScanDocsNo;

                return _EventHighlight;
            }
        }

        // need to add "Scanned Docs Stored: " (scandocs.count) when scanned docs directory are established on servers, or just ignore for now.

        /// <summary>
        /// Gets or sets the eventTrail of the FlowChange.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false)]
        //[NotNullOrEmpty(Key = "DetailsNotEmpty")
        public string EventTrail
        {
            get
            {
                string _EventTrail = String.Empty;
                _EventTrail = "Reported By: " + ReportedBy + _CrLf;

                if (ReportedTo != null)
                {
                    _EventTrail += "Reported To: " + ReportedTo != null ? Helpers.GetEmpFullName("ReportedTo", ReportedTo.Value, FacilNo) : "n/a" + _CrLf;
                }

                if (ReportedDate.HasValue)
                {
                    _EventTrail += "Reported Dt/Tm: " + ReportedDate.Value.ToString("MM/dd/yyyy") + " " + ReportedTime + _CrLf;
                }

                if (!String.IsNullOrEmpty(ReleaseType))
                {
                    switch (ReleaseType)
                    {
                        case "Full Release": _EventTrail += "Full Released by: " + ReleasedBy != null ? Helpers.GetEmpFullName("ReleasedBy", ReleasedBy.Value, FacilNo) : "n/a" + _CrLf;
                                            if (ReleasedTo != null)
                                            {
                                                _EventTrail += "Full Released to: " + ReleasedTo != null ? Helpers.GetEmpFullName("ReleasedTo", ReleasedTo.Value, FacilNo) : "n/a" + _CrLf;
                                            }    
                                            _EventTrail += "Full Released Dt/Tm: " + ReleasedDate.Value.ToString("MM/dd/yyyy") + " " + ReleasedTime + _CrLf;
                            break;
                        case "Test Release": _EventTrail += "Test Released by: " + +ReleasedBy != null ? Helpers.GetEmpFullName("ReleasedBy", ReleasedBy.Value, FacilNo) : "n/a" + _CrLf;
                                            if (ReleasedTo != null)
                                            {
                                                _EventTrail += "Test Released to: " + ReleasedTo != null ? Helpers.GetEmpFullName("ReleasedTo", ReleasedTo.Value, FacilNo) : "n/a" + _CrLf;
                                            }     
                                            _EventTrail += "Test Released Dt/Tm: " + ReleasedDate.Value.ToString("MM/dd/yyyy") + " " + ReleasedTime + _CrLf;
                            break;
                        case "Transfer": _EventTrail += "Transferred by: " + ReleasedBy != null ? Helpers.GetEmpFullName("ReleasedBy", ReleasedBy.Value, FacilNo) : "n/a" + _CrLf;
                                            //if (ReleasedTo != null) // There are no IssuedTo, IssuedDate, IssuedTime in SOC table
                                            //{
                                            //    _EventTrail += "Transferred to: " + IssuedTo != null ? PocketBook.Models.Dal.Helpers.GetEmpFullName("IssuedTo", IssuedTo.Value, FacilNo) : "n/a" + _CrLf;
                                            //}     
                                            //_EventTrail += "Transferred Dt/Tm: " + IssuedDate.ToString("MM/dd/yyyy") + " " + IssuedTime + _CrLf;
                            break;                        
                    }
                }
                
                if (!String.IsNullOrEmpty(OperatorID.ToString()))
                {
                    _EventTrail += "Logged By: " + Helpers.GetEmpFullName("LoggedBy", OperatorID, FacilNo) + _CrLf;
                    _EventTrail += "Logged Dt/Tm: " + UpdateDate.ToString("MM/dd/yyyy") + _CrLf;
                }

                if (NotifiedPerson != null)
                {
                    _EventTrail += "Notified Person: " + +NotifiedPerson != null ? Helpers.GetEmpFullName("Notified", NotifiedPerson.Value, FacilNo) : "n/a" + _CrLf;
                }
 
                return _EventTrail;
            }
        }

         #endregion
    }
}
