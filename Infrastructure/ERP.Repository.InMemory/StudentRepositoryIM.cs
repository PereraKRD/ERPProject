using ERP.Application.StudentApp.Interfaces;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.InMemory
{
    public class StudentRepositoryIM : IStudentRepository
    {
        private List<Student> _students;

        private void CreateStudentList(int size)
        {

            _students = Enumerable.Range(1, size).Select(index => new Student
            {
                StudentId = index + 1000,
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Phone = Faker.Phone.Number(),
                Address1 = Faker.Address.StreetAddress()

            }).ToList();

            foreach (var std in _students)
            {
                std.Email = Faker.Internet.Email(std.FirstName);
                std.RegistrationNum = $"EG/2020/{std.StudentId}";
            }
        }

        public StudentRepositoryIM()
        {
            CreateStudentList(5);
        }




        public async Task<IEnumerable<Student>> GetAllStudentsAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
                return await Task.FromResult(_students);
            else
            {
                return await Task.FromResult(_students.Where(x => x.FirstName.ToLower().StartsWith(name.ToLower())));
            }
        }

        public async Task<bool> ExistAsync(Student student)
        {
            return await Task.FromResult(_students.Any(x => x.StudentId == student.StudentId));
        }

        public Task AddStudentAsync(Student student)
        {
            var maxId = _students.Max(x => x.StudentId);
            student.StudentId = maxId + 1;
            _students.Add(student);
            return Task.CompletedTask;
        }

        public Task EditStudentAsync(Student std)
        {
            var student = _students.FirstOrDefault(x => x.StudentId == std.StudentId);

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

        public async Task<Student> GetStudentById(int studentId)
        {
            return await Task.FromResult(_students.FirstOrDefault(x => x.StudentId == studentId));


        }
    }
}
