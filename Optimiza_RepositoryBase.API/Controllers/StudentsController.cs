using Microsoft.AspNetCore.Mvc;
using Optimiza_RepositoryBase.API.Applications.Interfaces;
using Optimiza_RepositoryBase.API.Domain;

namespace Optimiza_RepositoryBase.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet("student-details")]
    public IActionResult StudentDetails()
    {
        var result = _studentService.GetStudentsDetailById();
        return Ok(result.Count == 0 ? [] : result);
    }

    [HttpGet("student-details-by-id")]
    public IActionResult StudentDetailById()
    {
        var result = _studentService.GetStudentsDetailById();
        return Ok(result.Count == 0 ? [] : result);
    }
    
    [HttpGet("students")]
    public IActionResult Students()
    {
        var result = _studentService.GetStudents();
        return Ok(result);
    }
    
    [HttpGet("student-by-id")]
    public IActionResult StudentById()
    {
        var result = _studentService.FindById(Guid.Parse("3cdd6589-2cb2-494-a01f-f9c0c602d048"));
        return Ok(result);
    }
    
    
    
}