using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface IEditEvaluationUseCase
{
    Task ExecuteAsync(Evaluation evaluation);
}