namespace ERP.Domain.Core.Entity
{
    public class Evaluation
    {
        public int EvaluationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Type {  get; set; }
        public double FinalMarks { get; set; }
        public double Marks { get; set; }
        
        public int ModuleOfferingID { get; set; }
        public ModuleOffering ModuleOffering { get; set; }
        public ICollection<StudentResult> Results { get; set; }

    }
}