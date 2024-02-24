using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IGetStudentListByModuleOfferingUseCase
{
    Task<List<Student>> ExecuteAsync(int moduleOfferingId);
}