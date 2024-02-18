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
    
    public async Task<Evaluation> ExecuteAsync(int moduleOfferingId, int evaluationType, double finalMarks,double marks, int totalMarks)
    {
        return await _moduleRepository.CreateEvaluationAsync(moduleOfferingId, evaluationType,finalMarks,marks, totalMarks);
    }
}