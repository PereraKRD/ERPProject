using System.Threading.Tasks.Dataflow;

namespace ERP.Domain.Core.Entity
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public Degree Specialization { get; set; }
        public Batch  Batch { get; set; }
        public ICollection<ModuleOffering> Modules { get; set; }
    }
}