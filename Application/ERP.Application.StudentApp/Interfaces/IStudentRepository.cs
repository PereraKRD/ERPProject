using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StudentApp.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync(string name);
        Task<bool> ExistAsync(Student student);
        Task AddStudentAsync(Student student);
        Task EditStudentAsync(Student student);
        Task<Student> GetStudentById(int studentId);
    }
}
