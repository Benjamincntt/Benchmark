using System.ComponentModel.DataAnnotations.Schema;

namespace Benchmark.Models;

public class StudentDetails 
{
    [Column("StudentDetailsId")]
    public Guid Id { get; set; }

    public string Address { get; set; }
    
    public string AdditionalInfomation { get; set; }
    
    public Guid StudentId { get; set; }
    
    public Student Student { get; set; }
}