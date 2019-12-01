using System.Collections.Generic;
using UniComparer.Models;

namespace UniComparer.Repository.Abstract
{
    public interface IGradeCategoryRepository
    {
        public ICollection<GradeCategory> GetGradeCategories();
    }
}
