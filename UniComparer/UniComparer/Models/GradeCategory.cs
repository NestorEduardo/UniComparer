using System.Collections.Generic;

namespace UniComparer.Models
{
    public class GradeCategory : BaseEntity
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
