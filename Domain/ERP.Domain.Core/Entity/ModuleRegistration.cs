namespace ERP.Domain.Core.Entity
{
    public class ModuleRegistration
    {
        public int ModuleRegistrationId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ModuleOfferingId { get; set; }
        public ModuleOffering ModuleOffering { get; set; }


    }
}