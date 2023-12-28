using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StudentApp.Students
{
    public class ViewStudentById : IViewStudentById
    {
        private readonly IStudentRepository studentRepository;

        public ViewStudentById(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<Student>
           ExecuteAsync(int studentId)
        {
            return await studentRepository.GetStudentById(studentId);
        }

    }
}
