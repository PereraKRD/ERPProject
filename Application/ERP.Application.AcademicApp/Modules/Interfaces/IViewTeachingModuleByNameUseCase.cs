using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IViewTeachingModuleByNameUseCase
{
    Task<IEnumerable<Module>> ExecuteAsync(string name = "");
}