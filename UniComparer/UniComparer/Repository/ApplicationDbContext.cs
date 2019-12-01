using Microsoft.EntityFrameworkCore;
using UniComparer.Models;

namespace UniComparer.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<GradeCategory> GradeCategories { get; set; }

    }
}
