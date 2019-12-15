using System.Collections.Generic;

namespace UniComparer.Models
{
    public class University : BaseEntity
    {
        public string ImageUrl { get; set; }
        public ICollection<GradeOffer> GradeOffers { get; set; }
        public ICollection<Campus> Campus { get; set; }
        public string PhoneNumber { get; set; }
        public string SiteUrl { get; set; }
    }
}
