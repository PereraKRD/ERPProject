using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Interfaces;

public interface IModuleRepository
{
    Task<IQueryable<ModuleOffering>> GetTeacherModulesAsync(int name);
}