using Microsoft.EntityFrameworkCore;
using StudentDB.Models;

namespace StudentDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
        public DbSet<Student> Students {get; set;}
    }
}
