using System;
using System.Collections.Generic;
using System.Linq;
using mvc4ESL.Models.BLL;

namespace PocketBook.Models.Collections
{
    public class FacilList : List<Facil>
    {
        public static FacilList facilList { get; set; }
        //{
        //    get;
        //    //{
        //    //    return FacilityManager.GetList().Where(f => f.FacilNo <= 13);
        //    //}
        //}
            
    }
}