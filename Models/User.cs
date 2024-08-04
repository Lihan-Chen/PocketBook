using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PocketBook.Models
{
    //[PrimaryKey(nameof(Id))]
    [NotMapped]
    //[Table("ESL_Users")]
    /// <summary>
    /// The User class represents an object in Entra ID with a link of EmployeeNo to the Employee class.  <see cref="Employee"> Employee</see>.
    /// </summary>
    public class User
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column(nameof(EmployeeNo))]
        public int EmployeeNo { get; set; }

        [Column("GivenName")] 
        public string FirstName { get; set; } = string.Empty;

        [Column("Surname")]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress]
        [Column("Mail")]
        public string Email { get; set; } = string.Empty;

        [EmailAddress]
        [Column(nameof(UserPrinicipalName))]
        public string UserPrinicipalName { get; set; } = string.Empty;

        public virtual Employee Employee { get; set; } = new Employee();

        // https://graph.microsoft.com/v1.0/me
        //{
        //"@odata.context": "https://graph.microsoft.com/v1.0/$metadata#users/$entity",
        //"@microsoft.graph.tips": "Use $select to choose only the properties your app needs, as this can lead to performance improvements. For example: GET me?$select=signInActivity,accountEnabled",
        //"userPrincipalName": "lchen@mwdh2o.com",
        //"id": "02965c76a8d0bbf9",
        //"displayName": "Lihan Chen",
        //"surname": "Chen",
        //"givenName": "Lihan",
        //"preferredLanguage": "en-US",
        //"mail": "lchen@mwdh2o.com",
        //"mobilePhone": null,
        //"jobTitle": null,
        //"officeLocation": null,
        //"businessPhones": []
        //}

    }
}
