﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Benchmark.Models;

public class Subject 
{
    [Column("SubjectId")]
    public Guid Id { get; set; }
    
    public string SubjectName { get; set; }

    public ICollection<StudentSubject> StudentSubjects { get; set; }
}