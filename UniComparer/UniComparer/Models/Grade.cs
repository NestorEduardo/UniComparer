namespace UniComparer.Models
{
    public class Grade : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int GradeCategoryId { get; set; }
        public virtual GradeCategory GradeCategory { get; set; }
    }
}
