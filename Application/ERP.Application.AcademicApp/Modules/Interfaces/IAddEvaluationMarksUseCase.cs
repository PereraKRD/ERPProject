namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IAddEvaluationMarksUseCase
{
    Task ExecuteAsync(int evaluationId, IDictionary<int, double> studentMarks);
}