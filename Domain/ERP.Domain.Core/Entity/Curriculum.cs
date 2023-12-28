namespace ERP.Domain.Core.Entity
{
    public class Curriculum
    {
        public int CurriculumId { get; set; }

        public ICollection<Module> Modules { get; set; }


    }
}