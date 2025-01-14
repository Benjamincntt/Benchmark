using System.ComponentModel.DataAnnotations.Schema;
using Optimiza_RepositoryBase.API.Abstractions;

namespace Optimiza_RepositoryBase.API.Domain;

public class StudentDetails : DomainEntity<Guid>
{
    [Column("StudentDetailsId")]
    public override Guid Id { get; set; }

    public string Address { get; set; }
    
    public string AdditionalInfomation { get; set; }
    
    public Guid StudentId { get; set; }
    
    public Student Student { get; set; }
}