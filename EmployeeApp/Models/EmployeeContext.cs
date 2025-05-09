using System.Data.Entity;

namespace EmployeeApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
