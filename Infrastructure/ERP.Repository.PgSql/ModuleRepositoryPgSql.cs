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
				.Include(mo => mo.Module) // Include related modules if necessary
				.Where(mo => mo.Coordinator.TeacherId == id);
			

		}
	}
}

