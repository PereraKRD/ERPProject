using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace ERP.Repository.PgSql.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasData(

               Enumerable.Range(1, 10).Select(
                   index => new Faker<Student>()
                         .RuleFor(s => s.StudentId, index + 1000)
                         .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                         .RuleFor(s => s.LastName, f => f.Name.LastName())
                         .RuleFor(s => s.Email, (f,u) => f.Internet.Email(u.FirstName,u.LastName))
                         .RuleFor(s => s.RegistrationNum, f => $"EG/{f.Random.Int(2020,2023)}/{f.Random.Int(1000, 9999)}").Generate()
                         
               )
            );

              
           

        }
    }
}
