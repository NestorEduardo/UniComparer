using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Repository.Abstract;

namespace UniComparer.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly ApplicationDbContext context;
        public GradeRepository(ApplicationDbContext context) => this.context = context;
        public ICollection<Grade> GetGradesByGradeCategoryId(int gradeCategoryId)
        {
            return context.Grades.Where(g => g.IsActive && g.GradeCategoryId == gradeCategoryId).Include(g => g.GradeCategory).ToList();
        }
    }
}
