using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> Options) : base(Options) { }
        public DbSet<Emp> Emps { get; set; }
    }
}
