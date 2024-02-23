using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegistrationNum = table.Column<string>(type: "text", nullable: false),
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
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    DegreeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId");
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Credits = table.Column<int>(type: "integer", nullable: false),
                    Semester = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CurriculumId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_Modules_Curriculum_CurriculumId",
                        column: x => x.CurriculumId,
                        principalTable: "Curriculum",
                        principalColumn: "CurriculumId");
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
                name: "ModuleOfferings",
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
                    table.PrimaryKey("PK_ModuleOfferings", x => x.ModuleOfferingId);
                    table.ForeignKey(
                        name: "FK_ModuleOfferings_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOfferings_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOfferings_Teachers_CoordinatorTeacherId",
                        column: x => x.CoordinatorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOfferings_Teachers_ExternalModeratorTeacherId",
                        column: x => x.ExternalModeratorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleOfferings_Teachers_ModeratorTeacherId",
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
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    FinalMarks = table.Column<double>(type: "double precision", nullable: false),
                    Marks = table.Column<double>(type: "double precision", nullable: false),
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId");
                });

            migrationBuilder.CreateTable(
                name: "ModuleFirstExaminers",
                columns: table => new
                {
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleFirstExaminers", x => new { x.ModuleOfferingId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleFirstExaminers_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleFirstExaminers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_ModuleRegistration_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
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
                name: "ModuleSecondExaminers",
                columns: table => new
                {
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSecondExaminers", x => new { x.ModuleOfferingId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleSecondExaminers_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId",
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
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleTeachers", x => new { x.ModuleOfferingId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_ModuleTeachers_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address1", "Address2", "City", "DegreeId", "District", "DoB", "Email", "FirstName", "LastName", "NationalID", "Phone", "PhoneNumber", "RegistrationNum" },
                values: new object[,]
                {
                    { 1001, "", "", "", null, "", new DateOnly(1, 1, 1), "Abby_Pagac27@gmail.com", "Abby", "Pagac", "", "", "", "EG/2022/7318" },
                    { 1002, "", "", "", null, "", new DateOnly(1, 1, 1), "Delilah37@gmail.com", "Delilah", "Stehr", "", "", "", "EG/2023/4197" },
                    { 1003, "", "", "", null, "", new DateOnly(1, 1, 1), "Clarabelle31@yahoo.com", "Clarabelle", "Bode", "", "", "", "EG/2020/4940" },
                    { 1004, "", "", "", null, "", new DateOnly(1, 1, 1), "Morton69@yahoo.com", "Morton", "Parker", "", "", "", "EG/2022/1532" },
                    { 1005, "", "", "", null, "", new DateOnly(1, 1, 1), "Moshe.Konopelski@hotmail.com", "Moshe", "Konopelski", "", "", "", "EG/2020/9926" },
                    { 1006, "", "", "", null, "", new DateOnly(1, 1, 1), "Tremayne.Ortiz57@gmail.com", "Tremayne", "Ortiz", "", "", "", "EG/2022/9674" },
                    { 1007, "", "", "", null, "", new DateOnly(1, 1, 1), "Brendon72@gmail.com", "Brendon", "VonRueden", "", "", "", "EG/2023/9653" },
                    { 1008, "", "", "", null, "", new DateOnly(1, 1, 1), "Alfred.Lemke@hotmail.com", "Alfred", "Lemke", "", "", "", "EG/2021/8408" },
                    { 1009, "", "", "", null, "", new DateOnly(1, 1, 1), "Camren39@gmail.com", "Camren", "Lebsack", "", "", "", "EG/2020/9535" },
                    { 1010, "", "", "", null, "", new DateOnly(1, 1, 1), "Alexandro.Zieme49@gmail.com", "Alexandro", "Zieme", "", "", "", "EG/2020/7208" }
                });

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
                name: "IX_ModuleFirstExaminers_TeacherId",
                table: "ModuleFirstExaminers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOfferings_CoordinatorTeacherId",
                table: "ModuleOfferings",
                column: "CoordinatorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOfferings_ExternalModeratorTeacherId",
                table: "ModuleOfferings",
                column: "ExternalModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOfferings_ModeratorTeacherId",
                table: "ModuleOfferings",
                column: "ModeratorTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOfferings_ModuleId",
                table: "ModuleOfferings",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleOfferings_SemesterId",
                table: "ModuleOfferings",
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
                name: "IX_Modules_CurriculumId",
                table: "Modules",
                column: "CurriculumId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleSecondExaminers_TeacherId",
                table: "ModuleSecondExaminers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleTeachers_TeacherId",
                table: "ModuleTeachers",
                column: "TeacherId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Students_DegreeId",
                table: "Students",
                column: "DegreeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleFirstExaminers");

            migrationBuilder.DropTable(
                name: "ModuleRegistration");

            migrationBuilder.DropTable(
                name: "ModuleSecondExaminers");

            migrationBuilder.DropTable(
                name: "ModuleTeachers");

            migrationBuilder.DropTable(
                name: "StudentResult");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "ModuleOfferings");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Curriculum");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
