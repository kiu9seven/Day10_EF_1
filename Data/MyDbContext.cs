using Day10.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Day10.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options): base(options) 
    {

    }
    public virtual DbSet<Student>? Students {get;set;}
}