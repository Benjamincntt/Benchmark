using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benchmark.Models;
[Table("Student")]
public class Student 
{
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(50,ErrorMessage = "Length must be less then 50 character")]
    public string Name { get; set; }
    
    public int? Age { get; set; }

    public bool IsRegularStudent { get; set; }

    public StudentDetails StudentDetails { get; set; }
    
    public ICollection<Evaluation> Evaluations { get; set; }
    
    public ICollection<StudentSubject> StudentSubjects { get; set; }
}