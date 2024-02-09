using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class ViewTeacherModuleByNameUseCase : IViewTeacherModuleByNameUseCase
{
    private readonly  IModuleRepository moduleRepository;


    public ViewTeacherModuleByNameUseCase(IModuleRepository moduleRepository)
    {
        this.moduleRepository = moduleRepository;
    }

    public async Task<IQueryable<ModuleOffering>> ExecuteAsync(int id)
    {
        return await moduleRepository.GetTeacherModulesAsync(id);
    }
}

