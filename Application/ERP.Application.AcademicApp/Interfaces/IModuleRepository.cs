using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Interfaces;

public interface IModuleRepository
{
    Task<IQueryable<ModuleOffering>> GetTeacherModulesAsync(int teacherId);
    Task<ModuleOffering> GetModuleOfferingAsync(int moduleOfferingId); 
    Task<Evaluation> CreateEvaluationAsync(int moduleOfferingId, int type,double Marks, double finalMarks, int totalMarks);
    
    // Task AddOrUpdateMarksAsync(int evaluationId, IDictionary<int, double> studentMarks);
    // Task<IEnumerable<StudentResult>> GetMarksByEvaluationIdAsync(int evaluationId);
}