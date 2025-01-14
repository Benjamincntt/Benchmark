using Optimiza_RepositoryBase.API.Abstractions;
using Optimiza_RepositoryBase.API.Applications.Interfaces;
using Optimiza_RepositoryBase.API.Domain;

namespace Optimiza_RepositoryBase.API.Applications.Inplements;

public class StudentServiceGood : IStudentServiceGood
{
    private readonly IRepositoryBaseGood<Student, Guid> _studentRepositoryGood;

    public StudentServiceGood(IRepositoryBaseGood<Student, Guid> studentRepositoryGood)
    {
        _studentRepositoryGood = studentRepositoryGood;
    }

    public List<Student> GetStudentDetail()
    {
        return _studentRepositoryGood.FindAll(x => x.StudentDetails, x => x.Evaluations).OrderBy(x => x.Name)
            .ToList();
    }

    public List<Student> GetStudentsDetailById()
    {
        return _studentRepositoryGood.FindAll(x => x.StudentDetails, x => x.Evaluations)
            .Where(x => x.Id.Equals(Guid.Parse("02225ea0-4029-41f7-b117-9a41cde997fd")))
            .OrderBy(x => x.Name).ToList();
    }

    public List<Student> GetStudents()
    {
        return _studentRepositoryGood.FindAll().OrderBy(x => x.Name).ToList();
    }

    public Task<Student> FindByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return _studentRepositoryGood.FindByIdAsync(id, cancellationToken);
    }

    public async Task<Student> FindByConditionAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _studentRepositoryGood.FindSingleAsync(x => x.Id.Equals(id), cancellationToken);
    }
}