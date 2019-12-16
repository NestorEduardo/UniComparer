using System.Collections.Generic;
using UniComparer.Models;
using UniComparer.Utils;

namespace UniComparer.Repository.Abstract
{
    public interface IGradeOfferRepository
    {
        public ICollection<GradeOffer> GetGradeOffersByGradeId(int gradeId, GradeOfferSortingOptions gradeOfferSortingOption);
        public GradeOffer GetGradeOffer(int gradeOfferId);
        public int GetGradeOffersCount();
    }
}
