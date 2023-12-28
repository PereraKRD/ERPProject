using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Interfaces;

public interface IModuleRepository
{
    Task<IEnumerable<Module>> GetTeacherModulesAsync(string name);
}