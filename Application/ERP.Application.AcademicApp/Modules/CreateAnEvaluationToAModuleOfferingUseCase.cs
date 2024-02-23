using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class CreateAnEvaluationToAModuleOfferingUseCase : ICreateAnEvaluationToAModuleOfferingUseCase
{
    private readonly  IModuleRepository _moduleRepository;

    public CreateAnEvaluationToAModuleOfferingUseCase(IModuleRepository moduleRepository)
    {
        this._moduleRepository = moduleRepository;
    }
    
    public  Task ExecuteAsync(Evaluation evaluation, int moduleOfferingId)
    { 
        return _moduleRepository.CreateEvaluationAsync(evaluation, moduleOfferingId);
    }
}