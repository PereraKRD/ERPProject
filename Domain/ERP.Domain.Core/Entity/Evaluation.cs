namespace ERP.Domain.Core.Entity
{
    public class Evaluation
    {
        public int EvaluationId { get; set; }
        public int Type {  get; set; }
        public double FinalMarks { get; set; }
        public double Marks { get; set; }
        public int TotalMarks { get; set; }
        public ICollection<StudentResult> Results { get; set; }

    }
}