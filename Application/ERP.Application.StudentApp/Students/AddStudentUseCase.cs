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
    public class AddStudentUseCase : IAddStudentUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public AddStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task ExecuteAsync(Student student)
        {
            await _studentRepository.AddStudentAsync(student);
        }
    }
}
