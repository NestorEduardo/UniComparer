using System.Collections.Generic;
using UniComparer.Models;

namespace UniComparer.Repository.Abstract
{
    public interface IGradeOfferRepository
    {
        public ICollection<GradeOffer> GetGradeOffersByGradeId(int gradeId);
        public GradeOffer GetGradeOffer(int gradeOfferId);
    }
}
