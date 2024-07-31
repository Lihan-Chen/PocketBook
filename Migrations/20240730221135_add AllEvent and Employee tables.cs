using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketBook.Migrations
{
    /// <inheritdoc />
    public partial class addAllEventandEmployeetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllEvents",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    LogTypeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EventID = table.Column<string>(type: "TEXT", nullable: false),
                    EventID_RevNo = table.Column<int>(type: "INTEGER", nullable: false),
                    FacilName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilAbbr = table.Column<string>(type: "TEXT", nullable: false),
                    LogTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    EventDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EventTime = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: false),
                    ModifyFlag = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    OperatorType = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<string>(type: "TEXT", nullable: false),
                    ClearanceID = table.Column<string>(type: "TEXT", nullable: false),
                    ScanDocsNo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllEvents", x => new { x.FacilNo, x.LogTypeNo, x.EventID, x.EventID_RevNo });
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    GroupName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Disable = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllEvents");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
