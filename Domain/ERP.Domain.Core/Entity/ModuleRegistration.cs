namespace ERP.Domain.Core.Entity
{
    public class ModuleRegistration
    {
        public int ModuleRegistrationId { get; set; }
        public Student Student { get; set; }
        public ModuleOffering Module { get; set; }

    }
}