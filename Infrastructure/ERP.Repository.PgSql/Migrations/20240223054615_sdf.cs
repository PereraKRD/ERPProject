using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class sdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleSecondExaminers");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Izaiah.Wolf49@hotmail.com", "Izaiah", "Wolf", "EG/2021/6096" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Juvenal.Rutherford@yahoo.com", "Juvenal", "Rutherford", "EG/2021/9375" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rodrick_Zboncak@gmail.com", "Rodrick", "Zboncak", "EG/2023/8468" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dominic46@hotmail.com", "Dominic", "Beer", "EG/2021/1250" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lola_Lebsack@hotmail.com", "Lola", "Lebsack", "EG/2022/7875" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Nigel_Wilkinson52@hotmail.com", "Nigel", "Wilkinson", "EG/2021/7528" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Aliza83@hotmail.com", "Aliza", "Mante", "EG/2022/9301" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jerald_Botsford27@yahoo.com", "Jerald", "Botsford", "EG/2021/7516" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Felipa_Klein@gmail.com", "Felipa", "Klein", "EG/2021/8644" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Verna.Mitchell@hotmail.com", "Verna", "Mitchell", "EG/2021/9916" });

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOfferings_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOfferings_TeacherId",
                table: "ModuleSecondExaminers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleFirstExaminers",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleSecondExaminers",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
