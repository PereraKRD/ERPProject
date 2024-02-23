using ERP.Domain.Core.Entity;
using ERP.Repository.PgSql.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            
            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasKey(mt => new { mt.ModuleOfferingId, mt.TeacherId });

            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasOne(mt => mt.ModuleOffering)
                .WithMany(mt => mt.Teachers)
                .HasForeignKey(mt => mt.ModuleOfferingId);
     

            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasOne(mt => mt.Teacher)
                .WithMany(mt => mt.TeachingModules)
                .HasForeignKey(mt => mt.TeacherId);


            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasKey(mf => new {mf.ModuleOfferingId,mf.TeacherId});

            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasOne(mf => mf.ModuleOffering)
                .WithMany(mf => mf.FirstExaminers)
                .HasForeignKey(mf => mf.TeacherId);

            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasOne(mf => mf.Teacher)
                .WithMany(mf => mf.FirstExaminersModules)
                .HasForeignKey(mf =>mf.TeacherId);


            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasKey(ms => new { ms.ModuleOfferingId, ms.TeacherId });

            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasOne(ms => ms.ModuleOffering)
                .WithMany(ms => ms.SecondExaminers)
                .HasForeignKey(ms => ms.TeacherId);

            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasOne(ms => ms.Teacher)
                .WithMany(ms => ms.SecondExaminersModules)
                .HasForeignKey(ms => ms.TeacherId);
            
            //defining PK for StudentResult
            modelBuilder.Entity<StudentResult>().HasKey(sr => new { sr.StudentId, sr.EvaluationId });
            
            //defining PK for Evaluation
            modelBuilder.Entity<Evaluation>().HasKey(e => new { e.EvaluationId });
            
            // Student and StudentResult (One-to-Many)
            modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentResults)
                .WithOne(sr => sr.Student)
                .HasForeignKey(sr => sr.StudentId);

            // Evaluation and StudentResult (One-to-Many)
            modelBuilder.Entity<Evaluation>()
                .HasMany(e => e.Results) 
                .WithOne(sr => sr.Evaluation)
                .HasForeignKey(sr => sr.EvaluationId);
            
            // ModuleOffering and Evaluation (One-to-Many)
            modelBuilder.Entity<ModuleOffering>()
                .HasMany(e => e.Evalutions)
                .WithOne(mo => mo.ModuleOffering)
                .HasForeignKey(mo => mo.ModuleOfferingID); 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ModuleOffering> ModuleOfferings { get; set; }
        public DbSet<ModuleOfferingTeacher> ModuleTeachers { get; set;}
        public DbSet<ModuleOfferingFirstExaminer> ModuleFirstExaminers { get; set; }
        public DbSet<ModuleOfferingSecondExaminer> ModuleSecondExaminers { get; set; }

    }
}
