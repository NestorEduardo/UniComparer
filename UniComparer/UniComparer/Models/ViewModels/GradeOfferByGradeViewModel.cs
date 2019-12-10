using System.Collections.Generic;

namespace UniComparer.Models.ViewModels
{
    public class GradeOfferByGradeViewModel
    {
        public ICollection<GradeOffer> GradeOffers { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
