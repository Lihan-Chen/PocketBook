using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocketBook.Models
{
    public class Plant
    {
        public int FacilNo { get; set; }
        public string FacilName { get; set; }
        public string FacilAbbr { get; set; }
        public List<Current_AllEvent> Current_AllEvents { get; set; }
    }
}

