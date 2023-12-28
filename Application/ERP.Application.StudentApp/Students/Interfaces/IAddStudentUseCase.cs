using ERP.Domain.Core.Entity;

namespace ERP.Application.StudentApp.Students.Interfaces
{
    public interface IAddStudentUseCase
    {
        Task ExecuteAsync(Student student);
    }
}