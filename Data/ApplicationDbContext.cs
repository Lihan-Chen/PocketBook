using Microsoft.EntityFrameworkCore;
using PocketBook.Models;
namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        // the dbset property will tell ef core that we have a table that needs to be created if it does not exist.
        public virtual DbSet<User>  Users { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Meter> Meters { get; set; }

        public virtual DbSet<AllEvent> AllEvents { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        // On model creating function will provide us with the ability to manage the tables properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity("PocketBook.Models.AllEvent", b =>
            {
                b.Property<int>("FacilNo")
                    .HasColumnType("INTEGER");

                b.Property<int>("LogTypeNo")
                    .HasColumnType("INTEGER");

                b.Property<string>("EventID")
                    .HasColumnType("TEXT");

                b.Property<int>("EventID_RevNo")
                    .HasColumnType("INTEGER");

                b.Property<string>("ClearanceID")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Details")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("EventDate")
                    .HasColumnType("TEXT");

                b.Property<string>("EventTime")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("FacilAbbr")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("FacilName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("LogTypeName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("ModifyFlag")
                    .HasColumnType("TEXT");

                b.Property<string>("Notes")
                    .HasColumnType("TEXT");

                b.Property<string>("OperatorType")
                    .HasColumnType("TEXT");

                b.Property<int>("ScanDocsNo")
                    .HasColumnType("INTEGER");

                b.Property<string>("Subject")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("UpdateDate")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("UpdatedBy")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("FacilNo", "LogTypeNo", "EventID", "EventID_RevNo");

                b.ToTable("AllEvents");
            });

            modelBuilder.Entity("PocketBook.Models.Employee", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER")
                    .HasColumnName("EmployeeNo");

                b.Property<string>("Company")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Disable")
                    .HasColumnType("TEXT");

                b.Property<int?>("FacilNo")
                    .HasColumnType("INTEGER");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("GroupName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("JobTitle")
                    .HasColumnType("TEXT");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Notes")
                    .HasColumnType("TEXT");

                b.Property<DateTimeOffset>("UpdateDate")
                    .HasColumnType("TEXT");

                b.Property<string>("UpdatedBy")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Employees");
            });

            modelBuilder.Entity("PocketBook.Models.Meter", b =>
            {
                b.Property<string>("MeterID")
                    .HasColumnType("TEXT");

                b.Property<string>("Disable")
                    .HasColumnType("TEXT");

                b.Property<int>("FacilNo")
                    .HasColumnType("INTEGER");

                b.Property<string>("MeterType")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Notes")
                    .HasColumnType("TEXT");

                b.Property<int?>("SortNo")
                    .HasColumnType("INTEGER");

                b.Property<DateTime?>("UpdateDate")
                    .HasColumnType("TEXT");

                b.Property<string>("UpdatedBy")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("MeterID");

                b.ToTable("Meters");
            });

            modelBuilder.Entity("PocketBook.Models.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Users");
            });
        }
    }
}
