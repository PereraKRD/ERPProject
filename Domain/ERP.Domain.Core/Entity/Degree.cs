namespace ERP.Domain.Core.Entity
{
    public class Degree
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public Department Department { get ; set; }

        public ICollection<Curriculum> Curricula { get; set; }

    }
}