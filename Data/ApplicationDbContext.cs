using Microsoft.EntityFrameworkCore;
using DisasterResourceFinder.Models;
namespace DisasterResourceFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Resource> Resources { get; set; }
    }
}
