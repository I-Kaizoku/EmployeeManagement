using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextoptions) : base(contextoptions)
        {

        }
        // code-Approach
        public DbSet<Employee> Employees { get; set; } 
    }
}
