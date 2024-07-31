using System.ComponentModel;

namespace PocketBook.Models
{
    public class LogEntity
    {
        /// <summary>
        /// Gets or sets the facilName of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]
        public int FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the facilName of the AllEvents.
        /// </summary>
        /// 
        [DataObjectField(false, false, false, 40)]
        public string FacilName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the facilAbbr of the AllEvents.
        /// </summary>
        /// 
        [DataObjectField(false, false, false, 5)]
        public string FacilAbbr { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the logTypeNo of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]
        public int LogTypeNo { get; set; }

        /// <summary>
        /// Gets or sets the logTypeName of the AllEvents.
        /// </summary>
        /// 
        [DataObjectField(false, false, false, 100)]
        public string LogTypeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the eventID of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 20)]
        public string EventID { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the eventID_RevNo of the AllEvents.
        /// </summary>
        [DataObjectField(true, true, false, 2)]
        public int EventID_RevNo { get; set; }
    }
}
