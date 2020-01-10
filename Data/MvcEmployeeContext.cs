using Microsoft.EntityFrameworkCore;
using MvcEmployees.Models;

namespace MvcEmployees.Data
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}