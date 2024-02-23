using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;

namespace ERP.Application.AcademicApp.Modules;

public class DeleteEvaluationUseCase : IDeleteEvaluationUseCase
{
    private readonly IModuleRepository _moduleRepository;
    
    public DeleteEvaluationUseCase(IModuleRepository moduleRepository)
    {
        this._moduleRepository = moduleRepository;
    }
    
    public async Task ExecuteAsync(int evaluationId)
    {
        await _moduleRepository.DeleteEvaluationAsync(evaluationId);
    }
}