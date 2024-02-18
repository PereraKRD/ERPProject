using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules.Interfaces;

public interface ICreateAnEvaluationToAModuleOfferingUseCase
{
    Task<Evaluation> ExecuteAsync(int moduleOfferingId, int evaluationType,double finalMarks, double marks, int totalMarks);

}