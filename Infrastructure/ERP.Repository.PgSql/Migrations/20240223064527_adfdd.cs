using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class adfdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentResult_Evaluation_EvaluationId",
                table: "StudentResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentResult",
                table: "StudentResult");

            migrationBuilder.DropIndex(
                name: "IX_StudentResult_StudentId",
                table: "StudentResult");

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationId",
                table: "StudentResult",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentResultId",
                table: "StudentResult",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentResult",
                table: "StudentResult",
                columns: new[] { "StudentId", "EvaluationId" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Rachael_Dickens84@hotmail.com", "Rachael", "Dickens", "EG/2022/7406" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Leone_Cormier95@yahoo.com", "Leone", "Cormier", "EG/2022/6765" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Eloy_Krajcik62@yahoo.com", "Eloy", "Krajcik", "EG/2020/3177" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dakota24@hotmail.com", "Dakota", "Hilll", "EG/2022/8284" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Veronica_Mueller@hotmail.com", "Veronica", "Mueller", "EG/2020/8772" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Odie74@gmail.com", "Odie", "Fisher", "EG/2021/2032" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Cali_Rice60@hotmail.com", "Cali", "Rice", "EG/2022/5034" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Ima87@gmail.com", "Ima", "Gislason", "EG/2023/5662" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Marcelina43@hotmail.com", "Marcelina", "Ledner", "EG/2021/9295" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Wilfredo.Runte@hotmail.com", "Wilfredo", "Runte", "EG/2020/1951" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResult_Evaluation_EvaluationId",
                table: "StudentResult",
                column: "EvaluationId",
                principalTable: "Evaluation",
                principalColumn: "EvaluationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentResult_Evaluation_EvaluationId",
                table: "StudentResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentResult",
                table: "StudentResult");

            migrationBuilder.AlterColumn<int>(
                name: "StudentResultId",
                table: "StudentResult",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "EvaluationId",
                table: "StudentResult",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentResult",
                table: "StudentResult",
                column: "StudentResultId");

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentResult_StudentId",
                table: "StudentResult",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResult_Evaluation_EvaluationId",
                table: "StudentResult",
                column: "EvaluationId",
                principalTable: "Evaluation",
                principalColumn: "EvaluationId");
        }
    }
}
