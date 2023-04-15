using Microsoft.EntityFrameworkCore;
using MVCCRUDApplication.Models.Domain;

namespace MVCCRUDApplication.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
