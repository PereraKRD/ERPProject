using ERP.Application.StudentApp.Interfaces;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql
{
    public class StudentRepositoryPgSql : IStudentRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public StudentRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }

        public Task AddStudentAsync(Student student)
        {
            using var _context = _factory.CreateDbContext();
            _context.Students.Add(student);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task EditStudentAsync(Student std)
        {
            using var _context = _factory.CreateDbContext();
            var student = _context.Students.FirstOrDefault(x => x.StudentId == std.StudentId);

            if (student != null)
            {
                student.FirstName = std.FirstName;
                student.LastName = std.LastName;
                student.Email = std.Email;
                student.Phone = std.Phone;
                student.Address1 = std.Address1;
            }

            return Task.CompletedTask;
        }

        public async Task<bool> ExistAsync(Student student)
        {
            using var _context = _factory.CreateDbContext();
            return await Task.FromResult(_context.Students.Any(x => x.StudentId == student.StudentId));
        }


        public async Task<IEnumerable<Student>> GetAllStudentsAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentId == studentId);

        }
    }
}
