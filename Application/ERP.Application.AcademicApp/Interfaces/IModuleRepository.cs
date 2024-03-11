using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Interfaces;

public interface IModuleRepository
{
    Task<IQueryable<ModuleOffering>> GetTeacherModulesAsync(int teacherId);
	Task<IQueryable<ModuleOfferingFirstExaminer>> GetFirstExaminerModulesAsync(int teacherId);
    Task<IQueryable<ModuleOfferingSecondExaminer>> GetSecondExaminerModulesAsync(int teacherId);
	Task<ModuleOffering> GetModuleOfferingAsync(int moduleOfferingId); 
    Task CreateEvaluationAsync(Evaluation evaluation, int moduleOfferingId);
    Task UpdateEvaluationAsync(Evaluation evaluation);
    Task DeleteEvaluationAsync(int evaluationId);
    Task <Evaluation> GetEvaluationByIdAsync(int evaluationId);

    Task<List<Student>> GetStudentsByModuleOfferingIdAsync(int moduleOfferingId);
	Task<List<StudentResult>> GetResultListByEvaluationIdAsync(int evaluationId);

}