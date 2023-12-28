using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class ViewTeachingModuleByNameUseCase : IViewTeachingModuleByNameUseCase
{
    private readonly  IModuleRepository moduleRepository;


    public ViewTeachingModuleByNameUseCase(IModuleRepository moduleRepository)
    {
        this.moduleRepository = moduleRepository;
    }

    public async Task<IEnumerable<Module>>
        ExecuteAsync(string name = "")
    {
        return await moduleRepository.GetTeacherModulesAsync(name);
    }
}

