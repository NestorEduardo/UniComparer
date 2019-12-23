using System.Collections.Generic;

namespace UniComparer.Models.ViewModels
{
    public class GradesByGradeCategoryViewModel
    {
        public ICollection<Grade> Grades { get; set; }
        public string Search { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
