```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


```
| Method                                    | IterationCount | Mean | Error |
|------------------------------------------ |--------------- |-----:|------:|
| **Student_GetStudentDetails**                 | **1**              |   **NA** |    **NA** |
| StudentGood_GetStudentDetails             | 1              |   NA |    NA |
| Student_GetStudentDetailsByIdNotFound     | 1              |   NA |    NA |
| StudentGood_GetStudentDetailsByIdNotFound | 1              |   NA |    NA |
| Student_GetStudents                       | 1              |   NA |    NA |
| StudentGood_GetStudents                   | 1              |   NA |    NA |
| Student_GetStudentsByIdAsync              | 1              |   NA |    NA |
| StudentGood_GetStudentsByIdAsync          | 1              |   NA |    NA |
| Student_GetStudentsByConditionAsync       | 1              |   NA |    NA |
| StudentGood_GetStudentsByConditionAsync   | 1              |   NA |    NA |
| **Student_GetStudentDetails**                 | **5**              |   **NA** |    **NA** |
| StudentGood_GetStudentDetails             | 5              |   NA |    NA |
| Student_GetStudentDetailsByIdNotFound     | 5              |   NA |    NA |
| StudentGood_GetStudentDetailsByIdNotFound | 5              |   NA |    NA |
| Student_GetStudents                       | 5              |   NA |    NA |
| StudentGood_GetStudents                   | 5              |   NA |    NA |
| Student_GetStudentsByIdAsync              | 5              |   NA |    NA |
| StudentGood_GetStudentsByIdAsync          | 5              |   NA |    NA |
| Student_GetStudentsByConditionAsync       | 5              |   NA |    NA |
| StudentGood_GetStudentsByConditionAsync   | 5              |   NA |    NA |

Benchmarks with issues:
  BenchmarkHarness.Student_GetStudentDetails: DefaultJob [IterationCount=1]
  BenchmarkHarness.StudentGood_GetStudentDetails: DefaultJob [IterationCount=1]
  BenchmarkHarness.Student_GetStudentDetailsByIdNotFound: DefaultJob [IterationCount=1]
  BenchmarkHarness.StudentGood_GetStudentDetailsByIdNotFound: DefaultJob [IterationCount=1]
  BenchmarkHarness.Student_GetStudents: DefaultJob [IterationCount=1]
  BenchmarkHarness.StudentGood_GetStudents: DefaultJob [IterationCount=1]
  BenchmarkHarness.Student_GetStudentsByIdAsync: DefaultJob [IterationCount=1]
  BenchmarkHarness.StudentGood_GetStudentsByIdAsync: DefaultJob [IterationCount=1]
  BenchmarkHarness.Student_GetStudentsByConditionAsync: DefaultJob [IterationCount=1]
  BenchmarkHarness.StudentGood_GetStudentsByConditionAsync: DefaultJob [IterationCount=1]
  BenchmarkHarness.Student_GetStudentDetails: DefaultJob [IterationCount=5]
  BenchmarkHarness.StudentGood_GetStudentDetails: DefaultJob [IterationCount=5]
  BenchmarkHarness.Student_GetStudentDetailsByIdNotFound: DefaultJob [IterationCount=5]
  BenchmarkHarness.StudentGood_GetStudentDetailsByIdNotFound: DefaultJob [IterationCount=5]
  BenchmarkHarness.Student_GetStudents: DefaultJob [IterationCount=5]
  BenchmarkHarness.StudentGood_GetStudents: DefaultJob [IterationCount=5]
  BenchmarkHarness.Student_GetStudentsByIdAsync: DefaultJob [IterationCount=5]
  BenchmarkHarness.StudentGood_GetStudentsByIdAsync: DefaultJob [IterationCount=5]
  BenchmarkHarness.Student_GetStudentsByConditionAsync: DefaultJob [IterationCount=5]
  BenchmarkHarness.StudentGood_GetStudentsByConditionAsync: DefaultJob [IterationCount=5]
