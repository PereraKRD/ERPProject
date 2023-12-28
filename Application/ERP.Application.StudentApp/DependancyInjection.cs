using ERP.Application.StudentApp.Students.Interfaces;
using ERP.Application.StudentApp.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StudentServiceCollection
    {
        

        public static IServiceCollection AddStudentServices(
             this IServiceCollection services)
        {
            services.AddScoped<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
            services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
            services.AddScoped<IViewStudentById, ViewStudentById>();
            services.AddScoped<IEditStudentUseCase, EditStudentUseCase>();

            return services;
        }
    }
}
