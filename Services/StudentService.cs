using Day10.Data;
using Day10.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day10.Services;

public class StudentService : IStudentService
{
    private readonly MyDbContext _context;
    public StudentService(MyDbContext context)
    { 
        _context = context;
    }

    public async Task<IList<Student>> GetAllAsync()
    {
        return _context.Students != null ? await _context.Students.ToListAsync(): new List<Student>();
    }

    public async Task<Student?> GetOneAsync(int id)
    {
        if (_context.Students == null) return null;
        return await _context.Students.SingleOrDefaultAsync(x => x.Id == id); 
    }

     public async Task<Student?> AddAsync(Student entity)
    {
        if (_context.Students == null) return null;
        await _context.Students.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Student Edit(Student entity)
    {
        throw new NotImplementedException();
    }
}