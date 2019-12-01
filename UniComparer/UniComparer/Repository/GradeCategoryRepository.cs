using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Repository.Abstract;

namespace UniComparer.Repository
{
    public class GradeCategoryRepository : IGradeCategoryRepository
    {
        private readonly ApplicationDbContext context;
        public GradeCategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public ICollection<GradeCategory> GetGradeCategories() => context.GradeCategories.Where(gc => gc.IsActive).ToList();
    }
}
