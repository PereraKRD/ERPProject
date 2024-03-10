using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class GetEvaluationByIdUseCase : IGetEvaluationByIdUseCase
{
    private readonly IModuleRepository _moduleRepository;
    
    public GetEvaluationByIdUseCase(IModuleRepository moduleRepository)
    {
        _moduleRepository = moduleRepository;
    }
    
    public async Task<Evaluation> ExecuteAsync(int evaluationId)
    {
        return await _moduleRepository.GetEvaluationByIdAsync(evaluationId);
    }
    
}