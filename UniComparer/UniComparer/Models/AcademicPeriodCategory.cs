using System.Collections.Generic;

namespace UniComparer.Models
{
    public class AcademicPeriodCategory : BaseEntity
    {
        public int NumberOfMonths { get; set; }
        public ICollection<GradeOffer> GradeOffers { get; set; }
    }
}
