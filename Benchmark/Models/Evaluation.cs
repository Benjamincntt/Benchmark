using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benchmark.Models;

public class Evaluation 
{
    [Column("EvaluationId")]
    public Guid Id { get; set; }
    
    public int Grade { get; set; }
    [Required]
    public string AdditionalExplanation { get; set; } 

    public Guid StudentId { get; set; }

    public Student Student { get; set; }
}