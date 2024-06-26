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
    Task AddOrUpdateMarksAsync(int evaluationId, IDictionary<int, double> studentMarks);
    Task<List<Student>> GetStudentsByModuleOfferingIdAsync(int moduleOfferingId);
	Task<List<StudentResult>> GetResultListByEvaluationIdAsync(int evaluationId);
    Task TransferRegisteredStudentsAsync (int evaluationId, List<Student> students);

}