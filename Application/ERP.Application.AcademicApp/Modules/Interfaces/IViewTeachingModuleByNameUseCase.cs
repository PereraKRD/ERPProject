using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IViewAllModuleByNameUseCase
{
    Task<IEnumerable<Module>> ExecuteAsync(string name = "");
}