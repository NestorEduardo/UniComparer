using System.Collections.Generic;

namespace UniComparer.Models.ViewModels
{
    public class GradesByGradeCategoryViewModel
    {
        public ICollection<Grade> Grades { get; set; }
        public string Search { get; set; }
    }
}
