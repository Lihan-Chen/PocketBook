namespace PocketBook.Models.Collections
{
    public class FacilList : List<Facil>
    {
        public static FacilList facilList { get; set; } = new FacilList();
        //{
        //    get;
        //    //{
        //    //    return FacilityManager.GetList().Where(f => f.FacilNo <= 13);
        //    //}
        //}
            
    }
}