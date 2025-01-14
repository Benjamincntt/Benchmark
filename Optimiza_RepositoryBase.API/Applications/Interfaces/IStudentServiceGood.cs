using Optimiza_RepositoryBase.API.Domain;

namespace Optimiza_RepositoryBase.API.Applications.Interfaces;

public interface IStudentServiceGood
{
    List<Student> GetStudentDetail();

    List<Student> GetStudentsDetailById();

    List<Student> GetStudents();

    Task<Student> FindByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Student> FindByConditionAsync(Guid id, CancellationToken cancellationToken = default);
}