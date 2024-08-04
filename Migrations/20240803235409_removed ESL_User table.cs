using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketBook.Migrations
{
    /// <inheritdoc />
    public partial class removedESL_Usertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ESL_Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ESL_Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    GivenName = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    UserPrinicipalName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ESL_Users_ESL_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "ESL_Employees",
                        principalColumn: "EmployeeNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ESL_Users_EmployeeId",
                table: "ESL_Users",
                column: "EmployeeId");
        }
    }
}
