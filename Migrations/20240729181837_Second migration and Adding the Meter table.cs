using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketBook.Migrations
{
    /// <inheritdoc />
    public partial class SecondmigrationandAddingtheMetertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    MeterID = table.Column<string>(type: "TEXT", nullable: false),
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    MeterType = table.Column<string>(type: "TEXT", nullable: false),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.MeterID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meters");
        }
    }
}
