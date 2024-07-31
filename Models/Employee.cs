﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;

namespace PocketBook.Models
{/// <summary>
 /// The Employee class represents an Employee that belongs to a <see cref="Facility">Employee</see>.
 /// </summary>
    [DebuggerDisplay("Employee: {Employee, nq}")]
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
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the First Name [VARCHAR2(50)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Company Name [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Company")]
        public string Company { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the Group Name [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Group Name")]
        public string GroupName { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the Facility No [NUMBER(3)] of the Facility.
        /// [DataObjectFieldAttribute(key, identity, isNullable, length]
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 3)]
        [DisplayName("Facility No.")]
        public int? FacilNo { get; set; }

        /// <summary>
        /// Gets or sets the Job Title [VARCHAR2(100)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 100)]
        [DisplayName("Job Title")]
        public string? JobTitle { get; set; } 

        /// <summary>
        /// Gets or sets the Notes [VARCHAR2(400)] of the Employee.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 400)]
        [DataType(DataType.MultilineText)]
        [DisplayName("Notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the Updated By [VARCHAR2(60)] of the Facility.  UpdatedBy defaults to user
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 60)]
        [DisplayName("Updated By")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Update Date [DATE] of the Facility. UpdateTime is default to sysdate
        /// </summary>
        [DataObjectFieldAttribute(false, false, true)]
        [DisplayName("Update Date")]
        public DateTimeOffset UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the Disable [VARCHAR2(15)] of the Facility.
        /// </summary>
        [DataObjectFieldAttribute(false, false, true, 30)]
        [DisplayName("Disabled?")]
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
