using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StudentApp.Students.Interfaces
{
    public interface IViewStudentById
    {
        Task<Student> ExecuteAsync(int stdudentId);
    }
}
