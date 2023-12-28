using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[,]
                {
                    { 1001, "929 Ayana Pike", "", "Misael", "O'Conner", "413.882.4342 x155", "" },
                    { 1002, "6297 Feil Coves", "", "Lucy", "Kovacek", "005.734.0378 x8516", "" },
                    { 1003, "67891 Pasquale Underpass", "", "Leanna", "Robel", "201.823.8239 x40277", "" },
                    { 1004, "3771 Gerhold Expressway", "", "Monserrate", "Tremblay", "314-242-2158", "" },
                    { 1005, "5669 Lizeth Cliff", "", "Lorenz", "Borer", "(043)768-6615 x488", "" },
                    { 1006, "157 Jacky Harbor", "", "Abner", "Leannon", "593.205.8972 x22785", "" },
                    { 1007, "189 Donnelly Extensions", "", "Howell", "Franecki", "351-923-9527", "" },
                    { 1008, "74645 Michele Garden", "", "Aliza", "Goyette", "(121)161-1563 x30650", "" },
                    { 1009, "430 Gutmann Landing", "", "Dortha", "Stokes", "012.511.0410", "" },
                    { 1010, "8763 Lolita Motorway", "", "Zula", "Abernathy", "954-944-3265", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010);
        }
    }
}
