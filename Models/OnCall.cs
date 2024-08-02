using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column("facil-no")]
        public int FacilNo  { get; set; }
        
        /// <summary>
        /// Gets or sets the logTypeNo of the General.
        /// </summary>
        public const int LogTypeNo =  6;

        /// <summary>
        /// Gets or sets the operatorID of the OnCall.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 7)]
        [Column("operator-id")]
        public int OperatorID { get; set; }

        /// <summary>
        /// Gets or sets the Notified Person's ID of the OnCall.
        /// </summary>
        [DataObjectFieldAttribute(false, false, false, 7)]
        [Column("subject")]
        public string Subject { get; set; }

        [DataObjectFieldAttribute(false, false, false, 600)]
        [Column("detail")]
        public string Details { get; set; }

        [DataObjectFieldAttribute(false, false, false, 200)]
        [Column("location")]
        public string Location { get; set; }

        #endregion
    }
}