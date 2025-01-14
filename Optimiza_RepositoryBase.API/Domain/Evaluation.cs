using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Optimiza_RepositoryBase.API.Abstractions;

namespace Optimiza_RepositoryBase.API.Domain;

public class Evaluation : DomainEntity<Guid>
{
    [Column("EvaluationId")]
    public override Guid Id { get; set; }
    
    public int Grade { get; set; }
    [Required]
    public string AdditionalExplanation { get; set; } 

    public Guid StudentId { get; set; }

    public Student Student { get; set; }
}