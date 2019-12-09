using System.Collections.Generic;

namespace UniComparer.Models.ViewModels
{
    public class GradeOfferDetailsViewModel
    {
        public GradeOffer GradeOffer{ get; set; }
        public ICollection<Campus> Campus { get; set; }
    }
}
