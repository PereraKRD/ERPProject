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
    public class ViewStudentsByNameUseCase : IViewStudentsByNameUseCase
    {
        private readonly IStudentRepository studentRepository;

        public ViewStudentsByNameUseCase(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>>
            ExecuteAsync(string name = "")
        {
            return await studentRepository.GetAllStudentsAsync(name);
        }
    }
}
