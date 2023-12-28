using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class bogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_Modules_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_CoordinatorTeacherId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_ExternalModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Teachers_ModeratorTeacherId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_Modules_TeacherId",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleTeachers_Modules_ModuleId",
                table: "ModuleTeachers");

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
                name: "CoordinatorTeacherId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ExternalModeratorTeacherId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "ModuleTeachers",
                newName: "ModuleOfferingId");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "ModuleSecondExaminers",
                newName: "ModuleOfferingId");

            migrationBuilder.RenameColumn(
                name: "ModeratorTeacherId",
                table: "Modules",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "ModuleFirstExaminers",
                newName: "ModuleOfferingId");

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumId",
                table: "Modules",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "Modules",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BatchName = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DegreeName = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_Degree_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curriculum",
                columns: table => new
                {
                    CurriculumId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DegreeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculum", x => x.CurriculumId);
                    table.ForeignKey(
                        name: "FK_Curriculum_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId");
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemesterName = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    SpecializationDegreeId = table.Column<int>(type: "integer", nullable: false),
                    BatchId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterId);
                    table.ForeignKey(
                        name: "FK_Semester_Batch_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batch",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Semester_Degree_SpecializationDegreeId",
                        column: x => x.SpecializationDegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Semester_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "ModuleOffering",
                columns: table => new
                {
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    CoordinatorTeacherId = table.Column<int>(type: "integer", nullable: false),
                    ModeratorTeacherId = table.Column<int>(type: "integer", nullable: false),
                    ExternalModeratorTeacherId = table.Column<int>(type: "integer", nullable: false),
                    SemesterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleOffering", x => x.ModuleOfferingId);
                    table.ForeignKey(
                        name: "FK_ModuleOffering_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOffering_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOffering_Teachers_CoordinatorTeacherId",
                        column: x => x.CoordinatorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOffering_Teachers_ExternalModeratorTeacherId",
                        column: x => x.ExternalModeratorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOffering_Teachers_ModeratorTeacherId",
                        column: x => x.ModeratorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    FinalMarks = table.Column<double>(type: "double precision", nullable: false),
                    Marks = table.Column<double>(type: "double precision", nullable: false),
                    TotalMarks = table.Column<int>(type: "integer", nullable: false),
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_ModuleOffering_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOffering",
                        principalColumn: "ModuleOfferingId");
                });

            migrationBuilder.CreateTable(
                name: "ModuleRegistration",
                columns: table => new
                {
                    ModuleRegistrationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRegistration", x => x.ModuleRegistrationId);
                    table.ForeignKey(
                        name: "FK_ModuleRegistration_ModuleOffering_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOffering",
                        principalColumn: "ModuleOfferingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRegistration_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentResult",
                columns: table => new
                {
                    StudentResultId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    StudentScore = table.Column<double>(type: "double precision", nullable: false),
                    EvaluationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentResult", x => x.StudentResultId);
                    table.ForeignKey(
                        name: "FK_StudentResult_Evaluation_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "Evaluation",
                        principalColumn: "EvaluationId");
                    table.ForeignKey(
                        name: "FK_StudentResult_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Gail_Auer7@hotmail.com", "Gail", "Auer", "", "EG/2021/6447" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Jefferey.Kshlerin47@gmail.com", "Jefferey", "Kshlerin", "", "EG/2023/6712" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Stevie35@hotmail.com", "Stevie", "Bosco", "", "EG/2022/7796" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Christy_Moore76@gmail.com", "Christy", "Moore", "", "EG/2022/5728" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Glenda_Marks@yahoo.com", "Glenda", "Marks", "", "EG/2023/7424" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Mellie.Deckow83@gmail.com", "Mellie", "Deckow", "", "EG/2023/9723" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Noah_Mosciski74@yahoo.com", "Noah", "Mosciski", "", "EG/2020/7537" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Darrel29@yahoo.com", "Darrel", "Goyette", "", "EG/2020/1430" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Cary64@hotmail.com", "Cary", "Senger", "", "EG/2023/2956" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Address1", "DegreeId", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "", null, "Coby66@hotmail.com", "Coby", "O'Reilly", "", "EG/2023/3277" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DegreeId",
                table: "Students",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CurriculumId",
                table: "Modules",
                column: "CurriculumId");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_DegreeId",
                table: "Curriculum",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Degree_DepartmentId",
                table: "Degree",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_ModuleOfferingId",
                table: "Evaluation",
                column: "ModuleOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOffering_CoordinatorTeacherId",
                table: "ModuleOffering",
                column: "CoordinatorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOffering_ExternalModeratorTeacherId",
                table: "ModuleOffering",
                column: "ExternalModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOffering_ModeratorTeacherId",
                table: "ModuleOffering",
                column: "ModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOffering_ModuleId",
                table: "ModuleOffering",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOffering_SemesterId",
                table: "ModuleOffering",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRegistration_ModuleOfferingId",
                table: "ModuleRegistration",
                column: "ModuleOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRegistration_StudentId",
                table: "ModuleRegistration",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_BatchId",
                table: "Semester",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SpecializationDegreeId",
                table: "Semester",
                column: "SpecializationDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_StudentId",
                table: "Semester",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResult_EvaluationId",
                table: "StudentResult",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResult_StudentId",
                table: "StudentResult",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOffering_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "ModuleOffering",
                principalColumn: "ModuleOfferingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Curriculum_CurriculumId",
                table: "Modules",
                column: "CurriculumId",
                principalTable: "Curriculum",
                principalColumn: "CurriculumId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Degree_DegreeId",
                table: "Students",
                column: "DegreeId",
                principalTable: "Degree",
                principalColumn: "DegreeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuleFirstExaminers_ModuleOffering_TeacherId",
                table: "ModuleFirstExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Curriculum_CurriculumId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleSecondExaminers_ModuleOffering_TeacherId",
                table: "ModuleSecondExaminers");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuleTeachers_ModuleOffering_ModuleOfferingId",
                table: "ModuleTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Degree_DegreeId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Curriculum");

            migrationBuilder.DropTable(
                name: "ModuleRegistration");

            migrationBuilder.DropTable(
                name: "StudentResult");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "ModuleOffering");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Students_DegreeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Modules_CurriculumId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurriculumId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "ModuleOfferingId",
                table: "ModuleTeachers",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "ModuleOfferingId",
                table: "ModuleSecondExaminers",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Modules",
                newName: "ModeratorTeacherId");

            migrationBuilder.RenameColumn(
                name: "ModuleOfferingId",
                table: "ModuleFirstExaminers",
                newName: "ModuleId");

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1001,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "070 Lizeth Lights", "", "Carrie", "Cronin", "(811)865-5166", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1002,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "881 Dietrich Mountain", "", "Theron", "Jakubowski", "1-979-355-2946 x0080", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1003,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "334 Dibbert Summit", "", "Elza", "Turcotte", "1-359-077-8858", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1004,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "5088 D'angelo Forge", "", "Joesph", "Murray", "498-686-7327", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1005,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "5271 Koch Extension", "", "Jayden", "Jones", "(772)930-2172 x74506", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1006,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "3320 Lang Port", "", "Cleo", "Jaskolski", "699.409.0142 x07062", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1007,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "9452 Lori Corners", "", "Ofelia", "Hickle", "1-831-253-5603 x337", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1008,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "2389 Kassandra Court", "", "Gonzalo", "Daugherty", "453.036.6839 x84043", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1009,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "02818 DuBuque Square", "", "Waldo", "Johns", "673.082.6720", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1010,
                columns: new[] { "Address1", "Email", "FirstName", "LastName", "Phone", "RegistrationNum" },
                values: new object[] { "888 Feil Court", "", "Estel", "Ryan", "220.092.3169 x65849", "" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleFirstExaminers_Modules_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleSecondExaminers_Modules_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuleTeachers_Modules_ModuleId",
                table: "ModuleTeachers",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
