﻿// <auto-generated />
using System;
using ERP.Repository.PgSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    [Migration("20240223052721_fff")]
    partial class fff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Domain.Core.Entity.Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BatchId"));

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("BatchId");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Curriculum", b =>
                {
                    b.Property<int>("CurriculumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CurriculumId"));

                    b.Property<int?>("DegreeId")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Curriculum");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("DegreeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.HasKey("DegreeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Evaluation", b =>
                {
                    b.Property<int>("EvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EvaluationId"));

                    b.Property<double>("FinalMarks")
                        .HasColumnType("double precision");

                    b.Property<double>("Marks")
                        .HasColumnType("double precision");

                    b.Property<int>("ModuleOfferingID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EvaluationId");

                    b.HasIndex("ModuleOfferingID");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<int?>("CurriculumId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("ModuleId");

                    b.HasIndex("CurriculumId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOffering", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleOfferingId"));

                    b.Property<int>("CoordinatorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ExternalModeratorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ModeratorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("SemesterId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId");

                    b.HasIndex("CoordinatorTeacherId");

                    b.HasIndex("ExternalModeratorTeacherId");

                    b.HasIndex("ModeratorTeacherId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SemesterId");

                    b.ToTable("ModuleOfferings");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingFirstExaminer", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleFirstExaminers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingSecondExaminer", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleSecondExaminers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingTeacher", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleTeachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleRegistration", b =>
                {
                    b.Property<int>("ModuleRegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleRegistrationId"));

                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleRegistrationId");

                    b.HasIndex("ModuleOfferingId");

                    b.HasIndex("StudentId");

                    b.ToTable("ModuleRegistration");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SemesterId"));

                    b.Property<int>("BatchId")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SpecializationDegreeId")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("SemesterId");

                    b.HasIndex("BatchId");

                    b.HasIndex("SpecializationDegreeId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DegreeId")
                        .HasColumnType("integer");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1001,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Courtney1@hotmail.com",
                            FirstName = "Courtney",
                            LastName = "Hodkiewicz",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2023/6376"
                        },
                        new
                        {
                            StudentId = 1002,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Ariel_Rice@gmail.com",
                            FirstName = "Ariel",
                            LastName = "Rice",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2022/3709"
                        },
                        new
                        {
                            StudentId = 1003,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Izabella.Gutmann@yahoo.com",
                            FirstName = "Izabella",
                            LastName = "Gutmann",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2023/4368"
                        },
                        new
                        {
                            StudentId = 1004,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Maybelle23@yahoo.com",
                            FirstName = "Maybelle",
                            LastName = "Windler",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2020/1228"
                        },
                        new
                        {
                            StudentId = 1005,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Zachary49@gmail.com",
                            FirstName = "Zachary",
                            LastName = "McLaughlin",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2023/1965"
                        },
                        new
                        {
                            StudentId = 1006,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Margarete.Gutkowski39@hotmail.com",
                            FirstName = "Margarete",
                            LastName = "Gutkowski",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2022/8496"
                        },
                        new
                        {
                            StudentId = 1007,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Estel_Bechtelar16@hotmail.com",
                            FirstName = "Estel",
                            LastName = "Bechtelar",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2021/4829"
                        },
                        new
                        {
                            StudentId = 1008,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Emery_Stiedemann15@yahoo.com",
                            FirstName = "Emery",
                            LastName = "Stiedemann",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2022/3727"
                        },
                        new
                        {
                            StudentId = 1009,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Quentin.Ritchie34@yahoo.com",
                            FirstName = "Quentin",
                            LastName = "Ritchie",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2021/8198"
                        },
                        new
                        {
                            StudentId = 1010,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Kacey_Weber@gmail.com",
                            FirstName = "Kacey",
                            LastName = "Weber",
                            NationalID = "",
                            Phone = "",
                            RegistrationNum = "EG/2020/4615"
                        });
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentResult", b =>
                {
                    b.Property<int>("StudentResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentResultId"));

                    b.Property<int?>("EvaluationId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<double>("StudentScore")
                        .HasColumnType("double precision");

                    b.HasKey("StudentResultId");

                    b.HasIndex("EvaluationId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentResult");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Curriculum", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Degree", null)
                        .WithMany("Curricula")
                        .HasForeignKey("DegreeId");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Degree", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Evaluation", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.ModuleOffering", null)
                        .WithMany("Evalutions")
                        .HasForeignKey("ModuleOfferingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Module", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Curriculum", null)
                        .WithMany("Modules")
                        .HasForeignKey("CurriculumId");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOffering", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "Coordinator")
                        .WithMany("CordinatingModules")
                        .HasForeignKey("CoordinatorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "ExternalModerator")
                        .WithMany()
                        .HasForeignKey("ExternalModeratorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Semester", "Semester")
                        .WithMany("Modules")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinator");

                    b.Navigation("ExternalModerator");

                    b.Navigation("Moderator");

                    b.Navigation("Module");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingFirstExaminer", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.ModuleOffering", "ModuleOffering")
                        .WithMany("FirstExaminers")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "Teacher")
                        .WithMany("FirstExaminersModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingSecondExaminer", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.ModuleOffering", "ModuleOffering")
                        .WithMany("SecondExaminers")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "Teacher")
                        .WithMany("SecondExaminersModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOfferingTeacher", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.ModuleOffering", "ModuleOffering")
                        .WithMany("Teachers")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Teacher", "Teacher")
                        .WithMany("TeachingModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleRegistration", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.ModuleOffering", "Module")
                        .WithMany("Registrations")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Semester", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.Degree", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Student", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId");

                    b.Navigation("Degree");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentResult", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.Evaluation", null)
                        .WithMany("Results")
                        .HasForeignKey("EvaluationId");

                    b.HasOne("ERP.Domain.Core.Entity.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Curriculum", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Degree", b =>
                {
                    b.Navigation("Curricula");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Evaluation", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.ModuleOffering", b =>
                {
                    b.Navigation("Evalutions");

                    b.Navigation("FirstExaminers");

                    b.Navigation("Registrations");

                    b.Navigation("SecondExaminers");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Semester", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Teacher", b =>
                {
                    b.Navigation("CordinatingModules");

                    b.Navigation("FirstExaminersModules");

                    b.Navigation("SecondExaminersModules");

                    b.Navigation("TeachingModules");
                });
#pragma warning restore 612, 618
        }
    }
}
