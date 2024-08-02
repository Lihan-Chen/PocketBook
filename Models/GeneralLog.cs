﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PocketBook.Models.Validation;
using PocketBook.Models.Dal;

namespace PocketBook.Models
{
    /// <summary>
    /// The FlowChange class represents an FlowChange that belongs to a <see cref="AllEvent"> AllEvent</see>.
    /// </summary>
    public class GeneralLog : BaseEvent
    {

        #region Private Variables

        //private string _CrLf = "<br />"; // Environment.NewLine ; // "\\r?\\n"; "<br />"; "\r\n";

        #endregion

        #region Public Properties

        [DataObjectFieldAttribute(false, false, true, 7)]
        [Display(Name = "Reported By (Optional)")]
        public int? ReportedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        public DateTime? EventDate { get; set; }

        [DataObjectFieldAttribute(false, false, true, 5)]
        public string EventTime { get; set; }
        
        [DataObjectFieldAttribute(false, false, false, 300)]
        public string Subject { get; set; }

        [DataObjectFieldAttribute(false, false, true, 600)]
        public string Details { get; set; }

        [DataObjectFieldAttribute(false, false, false, 200)]
        public string Location { get; set; }

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

                if (!String.IsNullOrEmpty(Subject))
                {
                    _EventHighlight += "Subject: " + Subject + _CrLf;
                }

                if (!String.IsNullOrEmpty(Details))
                {
                    _EventHighlight += "Details: " + Details + _CrLf;
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

                if (EventDate != null)
                {
                    _EventTrail = "Event Dt/Tm: " + EventDate.Value.ToString("MM/dd/yyyy") + ", " + EventTime + _CrLf;
                }

                if (!String.IsNullOrEmpty(OperatorID.ToString()))
                {
                    _EventTrail += "Logged By: " + Helpers.GetEmpFullName("LoggedBy", OperatorID, FacilNo) + _CrLf;
                    _EventTrail += "Logged Dt/Tm: " + UpdateDate.ToString("MM/dd/yyyy hh:mm") + _CrLf;
                }

                if (ReportedBy != null)
                {
                    _EventTrail += "Reported by: " + Helpers.GetEmpFullName("ReportedBy", ReportedBy.Value, FacilNo) + _CrLf;
                }

                if (NotifiedPerson != null)
                {
                    _EventTrail += "Notified Person: " + Helpers.GetEmpFullName("Notified", NotifiedPerson.Value, FacilNo) + _CrLf;
                } return _EventTrail;
            }
        }

        #endregion
    }
}