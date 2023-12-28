namespace ERP.Domain.Core.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string RegistrationNum { get; set; } = string.Empty;

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

        public Degree? Degree { get; set; }
        public ICollection<Semester> Semesters { get; set; }
    }
}
