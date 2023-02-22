using Microsoft.EntityFrameworkCore;
using FronToBack.Models;
namespace FronToBack.DAL;
class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Student> Students{get;set;}
}