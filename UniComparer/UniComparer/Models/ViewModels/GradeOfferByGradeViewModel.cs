using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using UniComparer.Utils;

namespace UniComparer.Models.ViewModels
{
    public class GradeOfferByGradeViewModel
    {
        public ICollection<GradeOffer> GradeOffers { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public SelectList GradeOfferSortingOptions { get; set; }
        public int GradeOfferSortingOption { get; set; }
    }
}
