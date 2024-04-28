using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.AcademicApp.Interfaces;
using ERP.Application.AcademicApp.Modules.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Application.AcademicApp.Modules
{
    public class TransferRegisteredStudentsToResultsUseCase : ITransferRegisteredStudentsToResultsUseCase
    {
        private readonly IModuleRepository _moduleRepository;

        public TransferRegisteredStudentsToResultsUseCase(IModuleRepository moduleRepository)
        {
            this._moduleRepository = moduleRepository;
        }

        public async Task ExecuteAsync(int evaluationId, List<Student> students)
        {
            await _moduleRepository.TransferRegisteredStudentsAsync(evaluationId, students);
        }
    }
}
