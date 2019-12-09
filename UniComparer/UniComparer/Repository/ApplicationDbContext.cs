using Microsoft.EntityFrameworkCore;
using UniComparer.Models;

namespace UniComparer.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<GradeCategory> GradeCategories { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<AcademicPeriodCategory> AcademicPeriodCategories { get; set; }
        public DbSet<GradeOffer> GradeOffers { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Campus> Campus { get; set; }
    }
}
