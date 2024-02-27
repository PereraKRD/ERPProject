using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IGetEvaluationByIdUseCase
{
    Task<Evaluation> ExecuteAsync(int evaluationId);
}