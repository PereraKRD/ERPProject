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
		
		public async Task<ModuleOffering> GetModuleOfferingAsync(int moduleOfferingId)
		{
			var _context = _factory.CreateDbContext();
			return await _context.ModuleOfferings
				       .Include(m => m.Module)
				       .Include(m => m.Semester)
				       .Include(m => m.Coordinator)
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

