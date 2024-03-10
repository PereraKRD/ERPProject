using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.AcademicApp.Modules.Interfaces
{
    public interface IGetResultListByStudentResultUseCase
    {
        Task<List<StudentResult>> ExecuteAsync(int evaluationId);
    }
}
