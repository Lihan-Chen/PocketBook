using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace PocketBook.Core.IConfiguration
{
    public interface IAuditable
    {
        //String CreatedBy { get; }
        
        //DateTime CreatedOnUtc { get; }

        //String ModifiedBy { get; }

        //DateTime? ModifiedOnUtc { get; }

        String UpdatedBy { get; }

        DateTime UpdateDate { get; }
    }
}
