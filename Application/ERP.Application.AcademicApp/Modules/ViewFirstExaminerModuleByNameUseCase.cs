using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.AcademicApp.Modules
{
	public class ViewFirstExaminerModuleByNameUseCase : IViewFirstExaminerModuleByNameUseCase
	{
		private readonly IModuleRepository moduleRepository;

		public ViewFirstExaminerModuleByNameUseCase(IModuleRepository moduleRepository)
		{
			this.moduleRepository = moduleRepository;
		}
		public async Task<IQueryable<ModuleOfferingFirstExaminer>> ExecuteAsync(int id)
		{
			return await moduleRepository.GetFirstExaminerModulesAsync(id);
		}
	}
}
