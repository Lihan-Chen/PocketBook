using System;
using System.ComponentModel;
using System.Diagnostics;
// using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    public class UserSession
    {
        public string? userID;
        public string? userName;
        public int   shiftNo;
        public string? shiftName;
        public string? operatorType;
        public bool isAdmin;
        public bool isSuperAdmin;
        public int   facilNo;
        public string? facilName;
        public bool userLoggedIn;
    }
}