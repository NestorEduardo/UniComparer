using System.Collections.Generic;
using UniComparer.Models;

namespace UniComparer.Repository.Abstract
{
    public interface IGradeRepository
    {
        public ICollection<Grade> GetGradesByGradeCategoryId(int gradeCategoryId);
        public int GetGradesCount();
    }
}
