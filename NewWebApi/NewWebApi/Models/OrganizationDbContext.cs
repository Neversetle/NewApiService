using Microsoft.EntityFrameworkCore;

namespace NewWebApi.Models
{
    public class OrganizationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-6S0TKR6;database=NewApi;Trusted_Connection=True;");
        }

        public DbSet<Department>? Departments { get; set; }
    }
}
