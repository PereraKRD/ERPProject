using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_ModuleOffering_ModuleOfferingId",
                table: "Evaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOffering_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOffering_Modules_ModuleId",
                table: "ModuleOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOffering_Semester_SemesterId",
                table: "ModuleOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOffering_Teachers_CoordinatorTeacherId",
                table: "ModuleOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOffering_Teachers_ExternalModeratorTeacherId",
                table: "ModuleOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOffering_Teachers_ModeratorTeacherId",
                table: "ModuleOffering");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistration_ModuleOffering_ModuleOfferingId",
                table: "ModuleRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOffering_TeacherId",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleTeachers_ModuleOffering_ModuleOfferingId",
                table: "ModuleTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleOffering",
                table: "ModuleOffering");

            migrationBuilder.RenameTable(
                name: "ModuleOffering",
                newName: "ModuleOfferings");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOffering_SemesterId",
                table: "ModuleOfferings",
                newName: "IX_ModuleOfferings_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOffering_ModuleId",
                table: "ModuleOfferings",
                newName: "IX_ModuleOfferings_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOffering_ModeratorTeacherId",
                table: "ModuleOfferings",
                newName: "IX_ModuleOfferings_ModeratorTeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOffering_ExternalModeratorTeacherId",
                table: "ModuleOfferings",
                newName: "IX_ModuleOfferings_ExternalModeratorTeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOffering_CoordinatorTeacherId",
                table: "ModuleOfferings",
                newName: "IX_ModuleOfferings_CoordinatorTeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleOfferings",
                table: "ModuleOfferings",
                column: "ModuleOfferingId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elyssa9@hotmail.com", "Elyssa", "Halvorson", "EG/2023/2984" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elinor.Wilkinson@hotmail.com", "Elinor", "Wilkinson", "EG/2022/1732" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Bertram82@hotmail.com", "Bertram", "Anderson", "EG/2023/7691" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Everett_Lehner@yahoo.com", "Everett", "Lehner", "EG/2022/5139" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Tessie.Olson88@yahoo.com", "Tessie", "Olson", "EG/2020/6887" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Monroe74@yahoo.com", "Monroe", "Shields", "EG/2021/3856" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Lavern9@gmail.com", "Lavern", "Robel", "EG/2022/3629" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Brielle75@gmail.com", "Brielle", "Waelchi", "EG/2023/6304" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Elouise59@hotmail.com", "Elouise", "Herzog", "EG/2022/5300" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Alexander13@hotmail.com", "Alexander", "Bode", "EG/2021/3749" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingId",
                table: "Evaluation",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOfferings_Modules_ModuleId",
                table: "ModuleOfferings",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOfferings_Semester_SemesterId",
                table: "ModuleOfferings",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOfferings_Teachers_CoordinatorTeacherId",
                table: "ModuleOfferings",
                column: "CoordinatorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOfferings_Teachers_ExternalModeratorTeacherId",
                table: "ModuleOfferings",
                column: "ExternalModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOfferings_Teachers_ModeratorTeacherId",
                table: "ModuleOfferings",
                column: "ModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistration_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistration",
                column: "ModuleOfferingId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleTeachers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleTeachers",
                column: "ModuleOfferingId",
                principalTable: "ModuleOfferings",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_ModuleOfferings_ModuleOfferingId",
                table: "Evaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOfferings_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOfferings_Modules_ModuleId",
                table: "ModuleOfferings");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOfferings_Semester_SemesterId",
                table: "ModuleOfferings");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOfferings_Teachers_CoordinatorTeacherId",
                table: "ModuleOfferings");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOfferings_Teachers_ExternalModeratorTeacherId",
                table: "ModuleOfferings");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleOfferings_Teachers_ModeratorTeacherId",
                table: "ModuleOfferings");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleRegistration_ModuleOfferings_ModuleOfferingId",
                table: "ModuleRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOfferings_TeacherId",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleTeachers_ModuleOfferings_ModuleOfferingId",
                table: "ModuleTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuleOfferings",
                table: "ModuleOfferings");

            migrationBuilder.RenameTable(
                name: "ModuleOfferings",
                newName: "ModuleOffering");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOfferings_SemesterId",
                table: "ModuleOffering",
                newName: "IX_ModuleOffering_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOfferings_ModuleId",
                table: "ModuleOffering",
                newName: "IX_ModuleOffering_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOfferings_ModeratorTeacherId",
                table: "ModuleOffering",
                newName: "IX_ModuleOffering_ModeratorTeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOfferings_ExternalModeratorTeacherId",
                table: "ModuleOffering",
                newName: "IX_ModuleOffering_ExternalModeratorTeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ModuleOfferings_CoordinatorTeacherId",
                table: "ModuleOffering",
                newName: "IX_ModuleOffering_CoordinatorTeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuleOffering",
                table: "ModuleOffering",
                column: "ModuleOfferingId");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Gail_Auer7@hotmail.com", "Gail", "Auer", "EG/2021/6447" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Jefferey.Kshlerin47@gmail.com", "Jefferey", "Kshlerin", "EG/2023/6712" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Stevie35@hotmail.com", "Stevie", "Bosco", "EG/2022/7796" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Christy_Moore76@gmail.com", "Christy", "Moore", "EG/2022/5728" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Glenda_Marks@yahoo.com", "Glenda", "Marks", "EG/2023/7424" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Mellie.Deckow83@gmail.com", "Mellie", "Deckow", "EG/2023/9723" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Noah_Mosciski74@yahoo.com", "Noah", "Mosciski", "EG/2020/7537" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Darrel29@yahoo.com", "Darrel", "Goyette", "EG/2020/1430" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Cary64@hotmail.com", "Cary", "Senger", "EG/2023/2956" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
                values: new object[] { "Coby66@hotmail.com", "Coby", "O'Reilly", "EG/2023/3277" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_ModuleOffering_ModuleOfferingId",
                table: "Evaluation",
                column: "ModuleOfferingId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOffering_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOffering_Modules_ModuleId",
                table: "ModuleOffering",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOffering_Semester_SemesterId",
                table: "ModuleOffering",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOffering_Teachers_CoordinatorTeacherId",
                table: "ModuleOffering",
                column: "CoordinatorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOffering_Teachers_ExternalModeratorTeacherId",
                table: "ModuleOffering",
                column: "ExternalModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleOffering_Teachers_ModeratorTeacherId",
                table: "ModuleOffering",
                column: "ModeratorTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleRegistration_ModuleOffering_ModuleOfferingId",
                table: "ModuleRegistration",
                column: "ModuleOfferingId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOffering_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleTeachers_ModuleOffering_ModuleOfferingId",
                table: "ModuleTeachers",
                column: "ModuleOfferingId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
