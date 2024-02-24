using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    NationalID = table.Column<string>(type: "text", nullable: false)
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
                name: "Semester",
                columns: table => new
                {
                    SemesterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemesterName = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    SpecializationDegreeId = table.Column<int>(type: "integer", nullable: false),
                    BatchId = table.Column<int>(type: "integer", nullable: false)
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
                name: "Evaluations",
                columns: table => new
                {
                    EvaluationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    FinalMarks = table.Column<double>(type: "double precision", nullable: false),
                    Marks = table.Column<double>(type: "double precision", nullable: false),
                    ModuleOfferingID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluations_ModuleOfferings_ModuleOfferingID",
                        column: x => x.ModuleOfferingID,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_ModuleFirstExaminers_ModuleOfferings_TeacherId",
                        column: x => x.TeacherId,
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
                name: "ModuleRegistrations",
                columns: table => new
                {
                    ModuleRegistrationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    ModuleOfferingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRegistrations", x => x.ModuleRegistrationId);
                    table.ForeignKey(
                        name: "FK_ModuleRegistrations_ModuleOfferings_ModuleOfferingId",
                        column: x => x.ModuleOfferingId,
                        principalTable: "ModuleOfferings",
                        principalColumn: "ModuleOfferingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRegistrations_Students_StudentId",
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
                        name: "FK_ModuleSecondExaminers_ModuleOfferings_TeacherId",
                        column: x => x.TeacherId,
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
                name: "StudentResults",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    EvaluationId = table.Column<int>(type: "integer", nullable: false),
                    StudentResultId = table.Column<int>(type: "integer", nullable: false),
                    StudentScore = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentResults", x => new { x.StudentId, x.EvaluationId });
                    table.ForeignKey(
                        name: "FK_StudentResults_Evaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "Evaluations",
                        principalColumn: "EvaluationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address1", "Address2", "City", "DegreeId", "District", "DoB", "Email", "FirstName", "LastName", "NationalID", "Phone", "RegistrationNum" },
                values: new object[,]
                {
                    { 1001, "", "", "", null, "", new DateOnly(1, 1, 1), "Abdul46@yahoo.com", "Abdul", "Gerlach", "", "", "EG/2022/4606" },
                    { 1002, "", "", "", null, "", new DateOnly(1, 1, 1), "Curtis_Monahan@gmail.com", "Curtis", "Monahan", "", "", "EG/2020/6124" },
                    { 1003, "", "", "", null, "", new DateOnly(1, 1, 1), "Estevan74@hotmail.com", "Estevan", "Wisoky", "", "", "EG/2020/4824" },
                    { 1004, "", "", "", null, "", new DateOnly(1, 1, 1), "Delphine.Mosciski77@gmail.com", "Delphine", "Mosciski", "", "", "EG/2021/9682" },
                    { 1005, "", "", "", null, "", new DateOnly(1, 1, 1), "Desiree.Gerlach@yahoo.com", "Desiree", "Gerlach", "", "", "EG/2023/1385" },
                    { 1006, "", "", "", null, "", new DateOnly(1, 1, 1), "Chet_Ortiz20@yahoo.com", "Chet", "Ortiz", "", "", "EG/2021/5142" },
                    { 1007, "", "", "", null, "", new DateOnly(1, 1, 1), "Paris33@gmail.com", "Paris", "Greenholt", "", "", "EG/2021/4901" },
                    { 1008, "", "", "", null, "", new DateOnly(1, 1, 1), "Jamel_Ortiz80@hotmail.com", "Jamel", "Ortiz", "", "", "EG/2022/5370" },
                    { 1009, "", "", "", null, "", new DateOnly(1, 1, 1), "Hailee69@yahoo.com", "Hailee", "Waters", "", "", "EG/2022/8631" },
                    { 1010, "", "", "", null, "", new DateOnly(1, 1, 1), "Terry.Lubowitz@hotmail.com", "Terry", "Lubowitz", "", "", "EG/2020/4931" }
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
                name: "IX_Evaluations_ModuleOfferingID",
                table: "Evaluations",
                column: "ModuleOfferingID");

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
                name: "IX_ModuleRegistrations_ModuleOfferingId",
                table: "ModuleRegistrations",
                column: "ModuleOfferingId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRegistrations_StudentId",
                table: "ModuleRegistrations",
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
                name: "IX_StudentResults_EvaluationId",
                table: "StudentResults",
                column: "EvaluationId");

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
                name: "ModuleRegistrations");

            migrationBuilder.DropTable(
                name: "ModuleSecondExaminers");

            migrationBuilder.DropTable(
                name: "ModuleTeachers");

            migrationBuilder.DropTable(
                name: "StudentResults");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Students");

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
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
