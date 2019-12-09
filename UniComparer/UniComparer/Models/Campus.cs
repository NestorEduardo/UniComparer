namespace UniComparer.Models
{
    public class Campus : BaseEntity
    {
        public string Address { get; set; }
        public string AddressUrl { get; set; }
        public bool IsPrincipal { get; set; }
        public int UniversityId { get; set; }
    }
}
