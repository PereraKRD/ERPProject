using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Core.Entity
{
    public class Teacher 
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public DateOnly DoB { get; set; }
        public string NationalID { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        [InverseProperty("Coordinator")]
        public ICollection<ModuleOffering> CordinatingModules {  get; set; }
        public ICollection<ModuleOfferingTeacher> TeachingModules { get; set; }
        public ICollection<ModuleOfferingFirstExaminer> FirstExaminersModules { get; set; }
        public ICollection<ModuleOfferingSecondExaminer> SecondExaminersModules { get; set; }


    }
}