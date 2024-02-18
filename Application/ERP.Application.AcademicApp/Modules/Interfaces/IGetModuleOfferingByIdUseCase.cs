using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IGetModuleOfferingByIdUseCase
{
    Task<ModuleOffering> ExecuteAsync(int moduleOfferingId);
    
    
}