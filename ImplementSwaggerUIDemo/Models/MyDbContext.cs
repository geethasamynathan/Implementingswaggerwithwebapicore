using Microsoft.EntityFrameworkCore;

namespace ImplementSwaggerUIDemo.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options) 
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
