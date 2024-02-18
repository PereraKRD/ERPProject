using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;

namespace ERP.Application.AcademicApp.Modules;

public class AddEvaluationMarksUseCase : IAddEvaluationMarksUseCase
{
    private readonly  IModuleRepository _moduleRepository;
    

    public AddEvaluationMarksUseCase(IModuleRepository moduleRepository)
    {
        this._moduleRepository = moduleRepository;
    }
    
    public async Task ExecuteAsync(int evaluationId, IDictionary<int, double> studentMarks)
    {
       // await _moduleRepository.AddOrUpdateMarksAsync(evaluationId, studentMarks);
    }
    
}