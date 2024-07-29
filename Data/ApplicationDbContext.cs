using Microsoft.EntityFrameworkCore;
using PocketBook.Models;
namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        // the dbset property will tell ef core that we have a table that needs to be created if it does not exist.
        public virtual DbSet<User>  Users { get; set; }

        public virtual DbSet<Meter> Meters { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        // On model creating function will provide us with the ability to manage the tables properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
