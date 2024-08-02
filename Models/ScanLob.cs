using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Collections;
using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models
{
    public class ScanLob
    {
        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false)]
        [DisplayName("Scan File No.")]
        public int ScanLobNo { get; set; }
         
        [DataObjectFieldAttribute(false, false, false)]
        [DisplayName("Facility No.")]
        public int FacilNo { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        public int LogTypeNo { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        public string EventID { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        [DisplayName("Scanned Document No.")]
        public int ScanNo { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        [DisplayName("Scan File Name")]
        public string ScanFileName { get; set; }

        [DataObjectFieldAttribute(false, false, false)]
        [DisplayName("Scan File Type")]
        public string ScanLobType { get; set; }
        
        [DataObjectFieldAttribute(false, false, false)]
        [DisplayName("File")]
        public Byte[] Blob { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTime UpdateDate { get; set; }
    }
}