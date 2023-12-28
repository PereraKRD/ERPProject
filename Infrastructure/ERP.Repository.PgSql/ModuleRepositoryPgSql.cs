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
		
		public async Task<IEnumerable<Module>> GetTeacherModulesAsync(string name)
		{
			using var _context = _factory.CreateDbContext();
			return await _context.Modules.ToListAsync();
		}
	}
}

