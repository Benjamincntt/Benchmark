using Optimiza_RepositoryBase.API.Domain;

namespace Optimiza_RepositoryBase.API.Applications.Interfaces;

public interface IStudentService
{
    List<Student> GetStudentDetail();

    List<Student> GetStudentsDetailById();

    List<Student> GetStudents();

    Student FindById(Guid Id);

    Student FindByCondition(Guid Id);
}