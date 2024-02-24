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
    public class ViewSecondExaminerModuleByNameUseCase : IViewSecondExaminerModuleByNameUseCase
    {
        private readonly IModuleRepository moduleRepository;

        public ViewSecondExaminerModuleByNameUseCase(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }
        public async Task<IQueryable<ModuleOfferingSecondExaminer>> ExecuteAsync(int id)
        {
            return await moduleRepository.GetSecondExaminerModulesAsync(id);
        }
    }
}
