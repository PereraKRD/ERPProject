namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IDeleteEvaluationUseCase
{
    public Task ExecuteAsync(int evaluationId);
}