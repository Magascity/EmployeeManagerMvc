using EmployeeManagerMvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerMvc.Security
{
    public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppIdentityDbContext
            (DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
            //nothing here

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
