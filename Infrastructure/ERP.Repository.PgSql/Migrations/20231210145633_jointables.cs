using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class jointables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Students",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DoB",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "NationalID",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CoordinatorTeacherId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExternalModeratorTeacherId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModeratorTeacherId",
                table: "Modules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Address1 = table.Column<string>(type: "text", nullable: false),
                    Address2 = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    DoB = table.Column<DateOnly>(type: "date", nullable: false),
                    NationalID = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "ModuleFirstExaminers",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleFirstExaminers", x => new { x.ModuleId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleFirstExaminers_Modules_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleFirstExaminers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleSecondExaminers",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSecondExaminers", x => new { x.ModuleId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleSecondExaminers_Modules_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleSecondExaminers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleTeachers",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleTeachers", x => new { x.ModuleId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleTeachers_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "070 Lizeth Lights", "", "", "", new DateOnly(1, 1, 1), "Carrie", "Cronin", "", "(811)865-5166", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "881 Dietrich Mountain", "", "", "", new DateOnly(1, 1, 1), "Theron", "Jakubowski", "", "1-979-355-2946 x0080", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "334 Dibbert Summit", "", "", "", new DateOnly(1, 1, 1), "Elza", "Turcotte", "", "1-359-077-8858", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "5088 D'angelo Forge", "", "", "", new DateOnly(1, 1, 1), "Joesph", "Murray", "", "498-686-7327", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "5271 Koch Extension", "", "", "", new DateOnly(1, 1, 1), "Jayden", "Jones", "", "(772)930-2172 x74506", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "3320 Lang Port", "", "", "", new DateOnly(1, 1, 1), "Cleo", "Jaskolski", "", "699.409.0142 x07062", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "9452 Lori Corners", "", "", "", new DateOnly(1, 1, 1), "Ofelia", "Hickle", "", "1-831-253-5603 x337", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "2389 Kassandra Court", "", "", "", new DateOnly(1, 1, 1), "Gonzalo", "Daugherty", "", "453.036.6839 x84043", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "02818 DuBuque Square", "", "", "", new DateOnly(1, 1, 1), "Waldo", "Johns", "", "673.082.6720", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Address1", "Address2", "City", "District", "DoB", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber" },
                values: new object[] { "888 Feil Court", "", "", "", new DateOnly(1, 1, 1), "Estel", "Ryan", "", "220.092.3169 x65849", "" });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CoordinatorTeacherId",
                table: "Modules",
                column: "CoordinatorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ExternalModeratorTeacherId",
                table: "Modules",
                column: "ExternalModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ModeratorTeacherId",
                table: "Modules",
                column: "ModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleFirstExaminers_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleSecondExaminers_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleTeachers_TeacherId",
                table: "ModuleTeachers",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Teachers_CoordinatorTeacherId",
                table: "Modules",
                column: "CoordinatorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Teachers_ExternalModeratorTeacherId",
                table: "Modules",
                column: "ExternalModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Teachers_ModeratorTeacherId",
                table: "Modules",
                column: "ModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_CoordinatorTeacherId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_ExternalModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_ModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "ModuleFirstExaminers");

            migrationBuilder.DropTable(
                name: "ModuleSecondExaminers");

            migrationBuilder.DropTable(
                name: "ModuleTeachers");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Modules_CoordinatorTeacherId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_ExternalModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_ModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CoordinatorTeacherId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ExternalModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ModeratorTeacherId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Students",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "929 Ayana Pike", "Misael", "O'Conner", "413.882.4342 x155" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "6297 Feil Coves", "Lucy", "Kovacek", "005.734.0378 x8516" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "67891 Pasquale Underpass", "Leanna", "Robel", "201.823.8239 x40277" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "3771 Gerhold Expressway", "Monserrate", "Tremblay", "314-242-2158" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "5669 Lizeth Cliff", "Lorenz", "Borer", "(043)768-6615 x488" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "157 Jacky Harbor", "Abner", "Leannon", "593.205.8972 x22785" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "189 Donnelly Extensions", "Howell", "Franecki", "351-923-9527" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "74645 Michele Garden", "Aliza", "Goyette", "(121)161-1563 x30650" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "430 Gutmann Landing", "Dortha", "Stokes", "012.511.0410" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { "8763 Lolita Motorway", "Zula", "Abernathy", "954-944-3265" });
        }
    }
}
