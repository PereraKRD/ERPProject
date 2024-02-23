namespace ERP.Domain.Core.Entity
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double StudentScore { get; set; }
        
        public int EvaluationId { get; set; }
        public Evaluation Evaluation { get; set; }

    }
}