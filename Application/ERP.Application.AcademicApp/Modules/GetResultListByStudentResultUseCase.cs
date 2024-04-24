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
    public class GetResultListByStudentResultUseCase : IGetResultListByStudentResultUseCase
    {
        private readonly IModuleRepository moduleRepository;

        public GetResultListByStudentResultUseCase(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }

        public async Task<List<StudentResult>> ExecuteAsync(int studentResultId)
        {
            return await moduleRepository.GetResultListByEvaluationIdAsync(studentResultId);
        }
    }
}
