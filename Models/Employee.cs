using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PocketBook.Models
{/// <summary>
 /// The Employee class represents an Employee that belongs to a <see cref="Facility">Employee</see>.
 /// </summary>
    [DebuggerDisplay("Employee: {Employee, nq}")]
    [PrimaryKey(nameof(Id))]
    [Table("ESL_Employees")]
    public class Employee // : IEntity
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the Employee No [NUMBER(8)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable]
        /// </summary>
        [DataObjectFieldAttribute(true, true, false, 8)]
        [DisplayName("MWD Employee ID")]
        [Column("EmployeeNo")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Last Name [VARCHAR2(50)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 50)]
        [DisplayName("Last Name")]
        [Column(nameof(LastName))]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the First Name [VARCHAR2(50)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 50)]
        [DisplayName("First Name")]
        [Column(nameof(FirstName))]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Company Name [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Company")]
        [Column(nameof(Company))]
        public string Company { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the Group Name [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Group Name")]
        [Column(nameof(GroupName))]
        public string GroupName { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable, length]
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 3)]
        [DisplayName("Facility No.")]
        [Column(nameof(FacilNo))]
        public int? FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the Job Title [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Job Title")]
        [Column(nameof(JobTitle))]
        public string? JobTitle { get; set; } 

        /// <summary>
        /// Gets or sets the Notes [VARCHAR2(400)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 400)]
        [DataType(DataType.MultilineText)]
        [DisplayName("Notes")]
        [Column(nameof(Notes))]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the Updated By [VARCHAR2(60)] of the Facility.  UpdatedBy defaults to user
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        [Column(nameof(UpdatedBy))]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Update Date [DATE] of the Facility. UpdateTime is default to sysdate
        /// </summary>
        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        [Column(nameof(UpdateDate))]
        public DateTimeOffset UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the Disable [VARCHAR2(15)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 30)]
        [DisplayName("Disabled?")]
        [Column(nameof(Disable))]
        public string? Disable { get; set; }

        /// Gets or sets the Full Name [VARCHAR2(50)] of the Employee.
        /// </summary>
        //[DataObjectFieldAttribute(false, false, false)]
        //[DisplayName("Full Name")]
        //public string FullName
        //{ 
        //    get
        //    {
        //        return LastName + ", " + FirstName + " - " + Company;
        //    }

        //}


        //public virtual ICollection<Plant> Plant { get; set; }
        //public virtual Role Role { get; set; }
        //public virtual Log Log { get; set; }
        //public virtual Log Log_AssignedBy { get; set; }
        #endregion

    }
}
