using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class GetStudentListByModuleOfferingUseCase : IGetStudentListByModuleOfferingUseCase
{
    private readonly IModuleRepository moduleRepository;

    public GetStudentListByModuleOfferingUseCase(IModuleRepository moduleRepository)
    {
        this.moduleRepository = moduleRepository;
    }
    
    public async Task<List<Student>> ExecuteAsync(int moduleOfferingId)
    {
        return await moduleRepository.GetStudentsByModuleOfferingIdAsync(moduleOfferingId);
    }
}