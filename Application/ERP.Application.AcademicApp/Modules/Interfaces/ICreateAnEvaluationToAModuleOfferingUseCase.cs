using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface ICreateAnEvaluationToAModuleOfferingUseCase
{
    Task ExecuteAsync(Evaluation evaluation, int moduleOfferingId);

}