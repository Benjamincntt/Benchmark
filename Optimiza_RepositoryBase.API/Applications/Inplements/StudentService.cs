using Optimiza_RepositoryBase.API.Abstractions;
using Optimiza_RepositoryBase.API.Applications.Interfaces;
using Optimiza_RepositoryBase.API.Domain;

namespace Optimiza_RepositoryBase.API.Applications.Inplements;

public class StudentService : IStudentService
{
    private readonly IRepositoryBase<Student, Guid> _studentRepository;
    //private readonly IUnitOfWork _unitOfWork;

    public StudentService(
        IRepositoryBase<Student, Guid> studentRepository
        //,IUnitOfWork unitOfWork
        )
    {
        _studentRepository = studentRepository;
        //_unitOfWork = unitOfWork;
    }

    // check case: AsNoTracking(); With No Include()
    public List<Student> GetStudents()
    {
        return _studentRepository.FindAll().OrderBy(x => x.Name).ToList();
    }
    
    // check case: AsNoTracking(); With Include() =>> SplitQuery =>> get all student and StudentDetails and Evaluation
    public List<Student> GetStudentDetail()
    {
        return _studentRepository.FindAll(x => x.StudentDetails, x => x.Evaluations).OrderBy(x => x.Name).ToList();
    }

    // check case: AsNoTracking(); With Include() =>> splitQuery => get dât but not found
    public List<Student> GetStudentsDetailById()
    {
        return _studentRepository.FindAll(x => x.StudentDetails, x => x.Evaluations)
            .Where(x => x.Id.Equals(Guid.Parse("02225ea0-4029-41f7-b117-9a41cde997fd")))
            .OrderBy(x => x.Name).ToList();
    }
    
    public Student FindById(Guid id)
    {
        return _studentRepository.FindById(id);
    }

    public Student FindByCondition(Guid id)
    {
        return _studentRepository.FindSingle(x => x.Id.Equals(id));
    }
}