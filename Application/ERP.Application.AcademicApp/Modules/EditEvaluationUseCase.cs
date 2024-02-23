using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules;

public class EditEvaluationUseCase : IEditEvaluationUseCase
{
    private readonly IModuleRepository _moduleRepository;
    
    public EditEvaluationUseCase(IModuleRepository moduleRepository)
    {
        this._moduleRepository = moduleRepository;
    }
    
    public async Task ExecuteAsync(Evaluation evaluation)
    {
        await _moduleRepository.UpdateEvaluationAsync(evaluation);
    }
    
    
}