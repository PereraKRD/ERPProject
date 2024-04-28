using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces
{
    public interface ITransferRegisteredStudentsToResultsUseCase
    {
        Task ExecuteAsync(int evaluationId, List<Student> students);
    }
}