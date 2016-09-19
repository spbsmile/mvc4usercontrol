using System.Data.Entity;

namespace MVC4UserControl.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}