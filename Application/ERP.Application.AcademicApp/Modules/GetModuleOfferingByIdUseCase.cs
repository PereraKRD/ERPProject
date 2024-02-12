using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class GetModuleOfferingByIdUseCase : IGetModuleOfferingByIdUseCase
{
    private readonly  IModuleRepository moduleRepository;


    public GetModuleOfferingByIdUseCase(IModuleRepository moduleRepository)
    {
        this.moduleRepository = moduleRepository;
    }

    public async Task<IQueryable<ModuleOffering>> ExecuteAsync(int moduleOfferingid)
    {
        return await moduleRepository.GetModuleOfferingAsync(moduleOfferingid);
    }
}