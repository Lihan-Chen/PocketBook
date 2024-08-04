using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketBook.Migrations
{
    /// <inheritdoc />
    public partial class updatedDetailswithforeignkeystoSubjectagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meters",
                table: "Meters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllEvents",
                table: "AllEvents");

            migrationBuilder.DropColumn(
                name: "FacilAbbr",
                table: "AllEvents");

            migrationBuilder.DropColumn(
                name: "FacilName",
                table: "AllEvents");

            migrationBuilder.DropColumn(
                name: "LogTypeName",
                table: "AllEvents");

            migrationBuilder.DropColumn(
                name: "ScanDocsNo",
                table: "AllEvents");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "ESL_Users");

            migrationBuilder.RenameTable(
                name: "Meters",
                newName: "ESL_Meters");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "ESL_Employees");

            migrationBuilder.RenameTable(
                name: "AllEvents",
                newName: "ESL_AllEvents");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ESL_Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "ESL_Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "ESL_Users",
                newName: "GivenName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ESL_Users",
                newName: "Mail");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "ESL_Users",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "ESL_Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNo",
                table: "ESL_Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserPrinicipalName",
                table: "ESL_Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ESL_Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "FacilityFacilNo",
                table: "ESL_Employees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClearanceID",
                table: "ESL_AllEvents",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ESL_Users",
                table: "ESL_Users",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ESL_Meters",
                table: "ESL_Meters",
                columns: new[] { "FacilNo", "MeterID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ESL_Employees",
                table: "ESL_Employees",
                column: "EmployeeNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ESL_AllEvents",
                table: "ESL_AllEvents",
                columns: new[] { "FacilNo", "LogTypeNo", "EventID", "EventID_RevNo" });

            migrationBuilder.CreateTable(
                name: "ESL_ClearanceTypes",
                columns: table => new
                {
                    ClearanceTypeNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClearanceTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    ClearanceTypeAbbr = table.Column<string>(type: "TEXT", nullable: false),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_ClearanceTypes", x => x.ClearanceTypeNo);
                });

            migrationBuilder.CreateTable(
                name: "ESL_ClearanceZones",
                columns: table => new
                {
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    ZoneNo = table.Column<int>(type: "INTEGER", nullable: false),
                    ZoneDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_ClearanceZones", x => new { x.FacilType, x.ZoneNo });
                });

            migrationBuilder.CreateTable(
                name: "ESL_Constants",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    ConstantName = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Value = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Constants", x => new { x.FacilNo, x.ConstantName, x.StartDate });
                });

            migrationBuilder.CreateTable(
                name: "ESL_EquipmentInvolved",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipNo = table.Column<int>(type: "INTEGER", nullable: false),
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    EquipName = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_EquipmentInvolved", x => new { x.FacilNo, x.EquipNo });
                });

            migrationBuilder.CreateTable(
                name: "ESL_Facilities",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilAbbr = table.Column<string>(type: "TEXT", nullable: false),
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    VisibleTo = table.Column<string>(type: "TEXT", nullable: true),
                    FacilFullName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Facilities", x => x.FacilNo);
                });

            migrationBuilder.CreateTable(
                name: "ESL_LogTypes",
                columns: table => new
                {
                    LogTypeNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LogTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_LogTypes", x => x.LogTypeNo);
                });

            migrationBuilder.CreateTable(
                name: "ESL_RelatedTo",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    LogTypeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EventID = table.Column<string>(type: "TEXT", nullable: false),
                    RelatedTo_Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_RelatedTo", x => new { x.FacilNo, x.LogTypeNo, x.EventID, x.RelatedTo_Subject });
                });

            migrationBuilder.CreateTable(
                name: "ESL_Subjects",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjNo = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Subjects", x => new { x.FacilNo, x.SubjNo });
                });

            migrationBuilder.CreateTable(
                name: "ESL_Units",
                columns: table => new
                {
                    UnitNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitName = table.Column<string>(type: "TEXT", nullable: true),
                    UnitDesc = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Units", x => x.UnitNo);
                });

            migrationBuilder.CreateTable(
                name: "ESL_WorkOrders",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    LogTypeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EventID = table.Column<string>(type: "TEXT", nullable: false),
                    WO_No = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_WorkOrders", x => new { x.FacilNo, x.LogTypeNo, x.EventID, x.WO_No });
                });

            migrationBuilder.CreateTable(
                name: "ESL_WorkToBePerformed",
                columns: table => new
                {
                    WorkNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    WorkDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_WorkToBePerformed", x => x.WorkNo);
                });

            migrationBuilder.CreateTable(
                name: "PlantsShiftList",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    ShiftNo = table.Column<int>(type: "INTEGER", nullable: false),
                    ShiftName = table.Column<string>(type: "TEXT", nullable: true),
                    ShiftStart = table.Column<string>(type: "TEXT", nullable: false),
                    ShiftEnd = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantsShiftList", x => new { x.FacilNo, x.ShiftNo });
                });

            migrationBuilder.CreateTable(
                name: "ESL_Details",
                columns: table => new
                {
                    FacilNo = table.Column<int>(type: "INTEGER", nullable: false),
                    DetailsNo = table.Column<int>(type: "INTEGER", nullable: false),
                    DetailsName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilType = table.Column<string>(type: "TEXT", nullable: false),
                    SortNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    SubjNo = table.Column<int>(type: "INTEGER", nullable: true),
                    Disable = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubjectFacilNo = table.Column<int>(type: "INTEGER", nullable: true),
                    SubjectNo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESL_Details", x => new { x.FacilNo, x.DetailsNo });
                    table.ForeignKey(
                        name: "FK_ESL_Details_ESL_Subjects_SubjectFacilNo_SubjectNo",
                        columns: x => new { x.SubjectFacilNo, x.SubjectNo },
                        principalTable: "ESL_Subjects",
                        principalColumns: new[] { "FacilNo", "SubjNo" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_ESL_Users_EmployeeId",
                table: "ESL_Users",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ESL_Employees_FacilityFacilNo",
                table: "ESL_Employees",
                column: "FacilityFacilNo");

            migrationBuilder.CreateIndex(
                name: "IX_ESL_Details_SubjectFacilNo_SubjectNo",
                table: "ESL_Details",
                columns: new[] { "SubjectFacilNo", "SubjectNo" });

            migrationBuilder.AddForeignKey(
                name: "FK_ESL_Employees_ESL_Facilities_FacilityFacilNo",
                table: "ESL_Employees",
                column: "FacilityFacilNo",
                principalTable: "ESL_Facilities",
                principalColumn: "FacilNo");

            migrationBuilder.AddForeignKey(
                name: "FK_ESL_Users_ESL_Employees_EmployeeId",
                table: "ESL_Users",
                column: "EmployeeId",
                principalTable: "ESL_Employees",
                principalColumn: "EmployeeNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ESL_Employees_ESL_Facilities_FacilityFacilNo",
                table: "ESL_Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_ESL_Users_ESL_Employees_EmployeeId",
                table: "ESL_Users");

            migrationBuilder.DropTable(
                name: "ESL_ClearanceTypes");

            migrationBuilder.DropTable(
                name: "ESL_ClearanceZones");

            migrationBuilder.DropTable(
                name: "ESL_Constants");

            migrationBuilder.DropTable(
                name: "ESL_Details");

            migrationBuilder.DropTable(
                name: "ESL_EquipmentInvolved");

            migrationBuilder.DropTable(
                name: "ESL_Facilities");

            migrationBuilder.DropTable(
                name: "ESL_LogTypes");

            migrationBuilder.DropTable(
                name: "ESL_RelatedTo");

            migrationBuilder.DropTable(
                name: "ESL_Units");

            migrationBuilder.DropTable(
                name: "ESL_WorkOrders");

            migrationBuilder.DropTable(
                name: "ESL_WorkToBePerformed");

            migrationBuilder.DropTable(
                name: "PlantsShiftList");

            migrationBuilder.DropTable(
                name: "ESL_Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ESL_Users",
                table: "ESL_Users");

            migrationBuilder.DropIndex(
                name: "IX_ESL_Users_EmployeeId",
                table: "ESL_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ESL_Meters",
                table: "ESL_Meters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ESL_Employees",
                table: "ESL_Employees");

            migrationBuilder.DropIndex(
                name: "IX_ESL_Employees_FacilityFacilNo",
                table: "ESL_Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ESL_AllEvents",
                table: "ESL_AllEvents");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ESL_Users");

            migrationBuilder.DropColumn(
                name: "EmployeeNo",
                table: "ESL_Users");

            migrationBuilder.DropColumn(
                name: "UserPrinicipalName",
                table: "ESL_Users");

            migrationBuilder.DropColumn(
                name: "FacilityFacilNo",
                table: "ESL_Employees");

            migrationBuilder.RenameTable(
                name: "ESL_Users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "ESL_Meters",
                newName: "Meters");

            migrationBuilder.RenameTable(
                name: "ESL_Employees",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "ESL_AllEvents",
                newName: "AllEvents");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "GivenName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClearanceID",
                table: "AllEvents",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacilAbbr",
                table: "AllEvents",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilName",
                table: "AllEvents",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LogTypeName",
                table: "AllEvents",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ScanDocsNo",
                table: "AllEvents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meters",
                table: "Meters",
                column: "MeterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllEvents",
                table: "AllEvents",
                columns: new[] { "FacilNo", "LogTypeNo", "EventID", "EventID_RevNo" });
        }
    }
}
