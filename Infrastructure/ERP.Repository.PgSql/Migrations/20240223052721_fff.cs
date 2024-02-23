using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class fff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semester_Students_StudentId",
                table: "Semester");

            migrationBuilder.DropIndex(
                name: "IX_Semester_StudentId",
                table: "Semester");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Semester");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Courtney1@hotmail.com", "Courtney", "Hodkiewicz", "EG/2023/6376" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ariel_Rice@gmail.com", "Ariel", "Rice", "EG/2022/3709" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Izabella.Gutmann@yahoo.com", "Izabella", "Gutmann", "EG/2023/4368" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Maybelle23@yahoo.com", "Maybelle", "Windler", "EG/2020/1228" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Zachary49@gmail.com", "Zachary", "McLaughlin", "EG/2023/1965" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Margarete.Gutkowski39@hotmail.com", "Margarete", "Gutkowski", "EG/2022/8496" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Estel_Bechtelar16@hotmail.com", "Estel", "Bechtelar", "EG/2021/4829" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Emery_Stiedemann15@yahoo.com", "Emery", "Stiedemann", "EG/2022/3727" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Quentin.Ritchie34@yahoo.com", "Quentin", "Ritchie", "EG/2021/8198" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Kacey_Weber@gmail.com", "Kacey", "Weber", "EG/2020/4615" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Semester",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Mollie71@gmail.com", "Mollie", "Pouros", "", "EG/2021/4013" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Alisha.OKon93@hotmail.com", "Alisha", "O'Kon", "", "EG/2021/1432" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Kole_Osinski91@gmail.com", "Kole", "Osinski", "", "EG/2021/5257" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Fay.Dibbert@hotmail.com", "Fay", "Dibbert", "", "EG/2021/6647" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Ardith84@gmail.com", "Ardith", "Morar", "", "EG/2020/7546" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Leann_Huel21@yahoo.com", "Leann", "Huel", "", "EG/2021/6433" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Karl2@hotmail.com", "Karl", "Ritchie", "", "EG/2021/1793" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Nakia59@yahoo.com", "Nakia", "Kulas", "", "EG/2022/5932" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Sabina_Weimann72@yahoo.com", "Sabina", "Weimann", "", "EG/2023/3917" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationNum" },
                values: new object[] { "Cicero5@yahoo.com", "Cicero", "Oberbrunner", "", "EG/2021/3889" });

            migrationBuilder.CreateIndex(
                name: "IX_Semester_StudentId",
                table: "Semester",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semester_Students_StudentId",
                table: "Semester",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
