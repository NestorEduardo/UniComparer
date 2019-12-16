using System.Collections.Generic;

namespace UniComparer.Models.ViewModels
{
    public class HomeViewModel
    {
        public ICollection<GradeCategory> GradeCategories { get; set; }
        public int UniversitiesCount { get; set; }
        public int GradesCount { get; set; }
        public int GradeOffersCount { get; set; }
    }
}
