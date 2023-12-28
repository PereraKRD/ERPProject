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

        public ICollection<ModuleOfferingTeacher> Teachers { get; set; }
        public ICollection<ModuleOfferingFirstExaminer> FirstExaminers { get; set; }
        public ICollection<ModuleOfferingSecondExaminer> SecondExaminers { get; set; }
        public ICollection<ModuleRegistration> Registrations { get; set; }

        public ICollection<Evaluation> Evalutions { get; set; }

    }
}
