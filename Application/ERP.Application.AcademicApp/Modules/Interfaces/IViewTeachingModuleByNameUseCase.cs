using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IViewTeacherModuleByNameUseCase
{
    Task<IQueryable<ModuleOffering>> ExecuteAsync(int id);
}