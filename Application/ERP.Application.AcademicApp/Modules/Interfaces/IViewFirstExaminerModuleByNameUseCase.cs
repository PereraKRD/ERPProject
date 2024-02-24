using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.AcademicApp.Modules.Interfaces
{
	public interface IViewFirstExaminerModuleByNameUseCase
	{
		Task<IQueryable<ModuleOfferingFirstExaminer>> ExecuteAsync(int id);
	}
}
