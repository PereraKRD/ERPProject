using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class ModReg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistration_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistration_Students_StudentId",
                table: "ModuleRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleRegistration",
                table: "ModuleRegistration");

            migrationBuilder.RenameTable(
                name: "ModuleRegistration",
                newName: "ModuleRegistrations");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleRegistration_StudentId",
                table: "ModuleRegistrations",
                newName: "IX_ModuleRegistrations_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleRegistration_ModuleOfferingId",
                table: "ModuleRegistrations",
                newName: "IX_ModuleRegistrations_ModuleOfferingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleRegistrations",
                table: "ModuleRegistrations",
                column: "ModuleRegistrationId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "May87@gmail.com", "May", "Ernser", "EG/2020/1360" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lenore.Schmeler@hotmail.com", "Lenore", "Schmeler", "EG/2022/3473" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gerry_Torphy@yahoo.com", "Gerry", "Torphy", "EG/2021/5360" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Christelle.Gibson7@yahoo.com", "Christelle", "Gibson", "EG/2020/6234" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Bernie96@yahoo.com", "Bernie", "Olson", "EG/2022/7902" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Anibal_Johnson@yahoo.com", "Anibal", "Johnson", "EG/2021/6623" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elmer_Lang@yahoo.com", "Elmer", "Lang", "EG/2022/6676" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Savannah.Beer94@yahoo.com", "Savannah", "Beer", "EG/2023/4367" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Dayne.Wiza@yahoo.com", "Dayne", "Wiza", "EG/2022/8370" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Calista68@gmail.com", "Calista", "Stiedemann", "EG/2022/6283" });

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistrations_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistrations",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistrations_Students_StudentId",
                table: "ModuleRegistrations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistrations_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistrations_Students_StudentId",
                table: "ModuleRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleRegistrations",
                table: "ModuleRegistrations");

            migrationBuilder.RenameTable(
                name: "ModuleRegistrations",
                newName: "ModuleRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleRegistrations_StudentId",
                table: "ModuleRegistration",
                newName: "IX_ModuleRegistration_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleRegistrations_ModuleOfferingId",
                table: "ModuleRegistration",
                newName: "IX_ModuleRegistration_ModuleOfferingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleRegistration",
                table: "ModuleRegistration",
                column: "ModuleRegistrationId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mckenna_Haley@yahoo.com", "Mckenna", "Haley", "EG/2020/3369" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Henri.Wisoky@gmail.com", "Henri", "Wisoky", "EG/2021/9205" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Hallie10@yahoo.com", "Hallie", "Hodkiewicz", "EG/2020/8492" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mayra55@gmail.com", "Mayra", "Tromp", "EG/2020/4803" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Keon60@gmail.com", "Keon", "Kunze", "EG/2023/1127" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Darius.Barton49@gmail.com", "Darius", "Barton", "EG/2023/9960" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Favian.Fisher@gmail.com", "Favian", "Fisher", "EG/2021/5446" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jailyn24@gmail.com", "Jailyn", "Vandervort", "EG/2020/3058" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Layne_Nitzsche85@hotmail.com", "Layne", "Nitzsche", "EG/2021/6068" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Onie51@yahoo.com", "Onie", "Hickle", "EG/2021/5115" });

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistration_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistration",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistration_Students_StudentId",
                table: "ModuleRegistration",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
