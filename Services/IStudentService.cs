using Day10.Data.Entities;

namespace Day10.Services;

public interface IStudentService
{
    public Task<IList<Student>> GetAllAsync();
    public Task<Student?> GetOneAsync(int id);
    public Task<Student?> AddAsync(Student entity);
    public Student? Edit(Student entity);
    public void Remove(int id);

}