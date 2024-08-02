using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PocketBook.Models.Validation;
using PocketBook.Models.Dal;
using Newtonsoft.Json;

namespace PocketBook.Models
{
    public struct OnCall
    {   
        #region Internal Variables

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the facilName of the OnCall.
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 2)]
        [JsonProperty(PropertyName = "facil-no")]
        public int FacilNo  { get; set; }
        
        /// <summary>
        /// Gets or sets the logTypeNo of the General.
        /// </summary>
        public const int LogTypeNo =  6;

        /// <summary>
        /// Gets or sets the operatorID of the OnCall.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 7)]
        [JsonProperty(PropertyName = "operator-id")]
        public int OperatorID { get; set; }

        /// <summary>
        /// Gets or sets the Notified Person's ID of the OnCall.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 7)]
        [JsonProperty(PropertyName = "notified-person")]
        public int NotifiedPerson { get; set; }

        ///// <summary>
        ///// Gets or sets the notes of the OnCall.  Default to: "Data Source: OnCall"
        ///// </summary>
        //public string Notes { get; set; }

        ///// <summary>
        ///// Gets or sets the notifiedFacil of the OnCall.
        ///// </summary>
        //[DataObjectFieldAttribute(false, false, true, 200)]
        //[Display(Name = "Notified Facility")]
        //public string NotifiedFacil { get; set; }
      
        [DataObjectFieldAttribute(false, false, false, 300)]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [DataObjectFieldAttribute(false, false, false, 600)]
        [JsonProperty(PropertyName = "detail")]
        public string Details { get; set; }

        [DataObjectFieldAttribute(false, false, false, 200)]
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        #endregion
    }
}