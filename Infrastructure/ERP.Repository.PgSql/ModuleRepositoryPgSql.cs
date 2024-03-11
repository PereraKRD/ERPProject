using System;
using ERP.Application.AcademicApp.Interfaces;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
	public class ModuleRepositoryPgSql : IModuleRepository
	{
		private readonly IDbContextFactory<PgSqlDbContext> _factory;

		public ModuleRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
		{
			_factory = factory;
		}
		
		public async Task<IQueryable<ModuleOffering>> GetTeacherModulesAsync(int id)
		{
			var _context = _factory.CreateDbContext();
			return  _context.ModuleOfferings
				.Include(mo => mo.Module) // Include related modules
				.Where(mo => mo.Coordinator.TeacherId == id);
			

		}

		public async Task<IQueryable<ModuleOfferingFirstExaminer>> GetFirstExaminerModulesAsync(int teacherId)
		{
			var _context = _factory.CreateDbContext();
			var query = _context.ModuleFirstExaminers
				.Include(mfe => mfe.ModuleOffering)
				.ThenInclude(mo => mo.Module)
				.Include(mfe => mfe.Teacher)
				.Where(mfe => mfe.TeacherId == teacherId);

			return query;
		}

        public async Task<IQueryable<ModuleOfferingSecondExaminer>> GetSecondExaminerModulesAsync(int teacherId)
        {
            var _context = _factory.CreateDbContext();
            var query = _context.ModuleSecondExaminers
                .Include(mfe => mfe.ModuleOffering)
                .ThenInclude(mo => mo.Module)
                .Include(mfe => mfe.Teacher)
                .Where(mfe => mfe.TeacherId == teacherId);

            return query;
        }

        public async Task<ModuleOffering> GetModuleOfferingAsync(int moduleOfferingId)
		{
			var _context = _factory.CreateDbContext();
			return await _context.ModuleOfferings
				       .Include(m => m.Module)
				       .Include(m => m.Semester)
				       .Include(m => m.Coordinator)
				       .Include(m => m.Evalutions)
				       .FirstOrDefaultAsync(m => m.ModuleOfferingId == moduleOfferingId)
			       ?? throw new Exception($"Module offering with ID {moduleOfferingId} not found.");
		}
		
		public async Task CreateEvaluationAsync(Evaluation evaluation, int moduleOfferingId)
		{
			using var _context = _factory.CreateDbContext();
			// Find the module offering
			var moduleOffering = await _context.ModuleOfferings
				.FirstOrDefaultAsync(mo => mo.ModuleOfferingId == moduleOfferingId);
			if (moduleOffering == null)
			{
				throw new ArgumentException("Module offering not found.", nameof(moduleOfferingId));
			}
			else
			{
				moduleOffering.Evalutions.Add(evaluation);
				await _context.SaveChangesAsync();
			}
			
		}
		
		public async Task UpdateEvaluationAsync(Evaluation updatedEvaluation)
		{
			using var _context = _factory.CreateDbContext();
			 var existingEvaluation =  _context.Evaluations.FirstOrDefault(e => e.EvaluationId == updatedEvaluation.EvaluationId);
			if (existingEvaluation == null)
			{
				throw new ArgumentException("Evaluation not found.", nameof(updatedEvaluation.EvaluationId));
			}

			// Updating properties
			existingEvaluation.Name = updatedEvaluation.Name;
			existingEvaluation.Type = updatedEvaluation.Type;
			existingEvaluation.FinalMarks = updatedEvaluation.FinalMarks;
			existingEvaluation.Marks = updatedEvaluation.Marks;

			// Save changes
			await _context.SaveChangesAsync();
		}
		
		public async Task DeleteEvaluationAsync(int evaluationId)
		{
			using var _context = _factory.CreateDbContext();
			var evaluation =  _context.Evaluations.FirstOrDefault(e => e.EvaluationId == evaluationId);
			if (evaluation == null)
			{
				throw new ArgumentException("Evaluation not found.", nameof(evaluationId));
			}
			_context.Evaluations.Remove(evaluation);
			await _context.SaveChangesAsync();
		}
		
		public async Task<List<Student>> GetStudentsByModuleOfferingIdAsync(int moduleOfferingId)
		{
			using var _context = _factory.CreateDbContext();
			var students = await _context.ModuleRegistrations
				.Where(mr => mr.ModuleOfferingId == moduleOfferingId)
				.Select(mr => mr.Student)
				.Distinct()
				.ToListAsync();

			return students;
		}
		
		public async Task<Evaluation> GetEvaluationByIdAsync(int evaluationId)
		{
			using var _context = _factory.CreateDbContext();
			return await _context.Evaluations
				.FirstOrDefaultAsync(e => e.EvaluationId == evaluationId)
				?? throw new Exception($"Evaluation with ID {evaluationId} not found.");
		}

		public async Task<List<StudentResult>> GetResultListByEvaluationIdAsync(int evaluationId)
		{
			using var _context = _factory.CreateDbContext();
			var studentResults = await _context.StudentResults
				.Where(sr => sr.EvaluationId == evaluationId)
				.Include(sr => sr.Student)
				.Select(sr => new StudentResult
				{
					StudentResultId = sr.StudentResultId,
					Student = sr.Student,
					StudentScore = sr.StudentScore,
					EvaluationId = sr.EvaluationId,
				})
				.Distinct()
				.ToListAsync();

			return studentResults;
		}

		// public async Task AddOrUpdateMarksAsync(int evaluationId, IDictionary<int, double> studentMarks)
		// {
		// 	// Logic to add or update marks for the specified evaluation
		// }
		//
		// public async Task<IEnumerable<StudentResult>> GetMarksByEvaluationIdAsync(int evaluationId)
		// {
		// 	// Logic to retrieve marks for the specified evaluation
		// }


	}
}

