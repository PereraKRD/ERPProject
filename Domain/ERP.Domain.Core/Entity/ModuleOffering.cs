using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
    public class ModuleOffering
    {
        public int ModuleOfferingId { get; set; }
        public Module Module { get; set; }  

        public Teacher Coordinator { get; set; }
        public Teacher Moderator { get; set; }
        public Teacher ExternalModerator { get; set; }

        public Semester Semester { get; set; }

        public ICollection<ModuleOfferingTeacher> Teachers { get; set; } = new List<ModuleOfferingTeacher>();

        public ICollection<ModuleOfferingFirstExaminer> FirstExaminers { get; set; } =
            new List<ModuleOfferingFirstExaminer>();

        public ICollection<ModuleOfferingSecondExaminer> SecondExaminers { get; set; } =
            new List<ModuleOfferingSecondExaminer>();
        public ICollection<ModuleRegistration> Registrations { get; set; } = new List<ModuleRegistration>();
        public ICollection<Evaluation> Evalutions { get; set; } = new List<Evaluation>();
    }
}
