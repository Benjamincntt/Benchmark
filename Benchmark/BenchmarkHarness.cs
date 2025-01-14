using Benchmark.Services;
using BenchmarkDotNet.Attributes;

namespace Benchmark;
[HtmlExporter]
public class BenchmarkHarness
{
    [Params(1, 5)] 
    public int IterationCount;
    private readonly StudentHttpClient _studentHttpClient = new StudentHttpClient();
    private readonly StudentGoodHttpClient _studentGoodHttpClient = new StudentGoodHttpClient();

    [Benchmark]
    public async Task Student_GetStudentDetails()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentHttpClient.GetStudentDetailsAsync();
        }
    }

    [Benchmark]
    public async Task StudentGood_GetStudentDetails()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentGoodHttpClient.GetStudentDetailsAsync();
        }
    }
    
    [Benchmark]
    public async Task Student_GetStudentDetailsByIdNotFound()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentHttpClient.GetStudentDetailsByIdAsync();
        }
    }
    
    [Benchmark]
    public async Task StudentGood_GetStudentDetailsByIdNotFound()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentGoodHttpClient.GetStudentDetailsByIdAsync();
        }
    }
    
    /// <summary>
    /// Has No Data within Include statement
    /// </summary>
    [Benchmark]
    public async Task Student_GetStudents()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentHttpClient.GetStudentAsync();
        }
    }
    
    [Benchmark]
    public async Task StudentGood_GetStudents()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentGoodHttpClient.GetStudentAsync();
        }
    }

    /// <summary>
    /// FindbyId-FindByCondition Async - sync
    /// </summary>
    [Benchmark]
    public async Task Student_GetStudentsByIdAsync()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentHttpClient.GetStudentByIdAsync();
        }
    }
    
    [Benchmark]
    public async Task StudentGood_GetStudentsByIdAsync()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentGoodHttpClient.GetStudentByIdAsync();
        }
    }

    [Benchmark]
    public async Task Student_GetStudentsByConditionAsync()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentHttpClient.GetStudentByConditionAsync();
        }
    }
    
    [Benchmark]
    public async Task StudentGood_GetStudentsByConditionAsync()
    {
        for (var i = 0; i < IterationCount; i++)
        {
            await _studentGoodHttpClient.GetStudentByConditionAsync();
        }
    }

}