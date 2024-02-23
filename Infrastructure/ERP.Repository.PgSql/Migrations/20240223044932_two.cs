using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingId",
                table: "Evaluation");

            migrationBuilder.RenameColumn(
                name: "ModuleOfferingId",
                table: "Evaluation",
                newName: "ModuleOfferingID");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluation_ModuleOfferingId",
                table: "Evaluation",
                newName: "IX_Evaluation_ModuleOfferingID");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleOfferingID",
                table: "Evaluation",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Iliana_Macejkovic@gmail.com", "Iliana", "Macejkovic", "EG/2020/7596" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Nolan93@hotmail.com", "Nolan", "Maggio", "EG/2023/3069" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jerald1@gmail.com", "Jerald", "Feil", "EG/2021/5327" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Verda_Lesch29@hotmail.com", "Verda", "Lesch", "EG/2021/2408" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mateo12@hotmail.com", "Mateo", "Frami", "EG/2023/7242" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Koby.Halvorson@yahoo.com", "Koby", "Halvorson", "EG/2020/6096" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Audra28@yahoo.com", "Audra", "Kassulke", "EG/2021/5216" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Raina99@hotmail.com", "Raina", "Herzog", "EG/2021/7012" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Joan.Stiedemann@yahoo.com", "Joan", "Stiedemann", "EG/2022/7161" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Margie.Jenkins27@hotmail.com", "Margie", "Jenkins", "EG/2020/1767" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingID",
                table: "Evaluation",
                column: "ModuleOfferingID",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingID",
                table: "Evaluation");

            migrationBuilder.RenameColumn(
                name: "ModuleOfferingID",
                table: "Evaluation",
                newName: "ModuleOfferingId");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluation_ModuleOfferingID",
                table: "Evaluation",
                newName: "IX_Evaluation_ModuleOfferingId");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleOfferingId",
                table: "Evaluation",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Abby_Pagac27@gmail.com", "Abby", "Pagac", "EG/2022/7318" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Delilah37@gmail.com", "Delilah", "Stehr", "EG/2023/4197" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Clarabelle31@yahoo.com", "Clarabelle", "Bode", "EG/2020/4940" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Morton69@yahoo.com", "Morton", "Parker", "EG/2022/1532" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Moshe.Konopelski@hotmail.com", "Moshe", "Konopelski", "EG/2020/9926" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tremayne.Ortiz57@gmail.com", "Tremayne", "Ortiz", "EG/2022/9674" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Brendon72@gmail.com", "Brendon", "VonRueden", "EG/2023/9653" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alfred.Lemke@hotmail.com", "Alfred", "Lemke", "EG/2021/8408" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Camren39@gmail.com", "Camren", "Lebsack", "EG/2020/9535" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alexandro.Zieme49@gmail.com", "Alexandro", "Zieme", "EG/2020/7208" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingId",
                table: "Evaluation",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId");
        }
    }
}
