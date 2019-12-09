using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Repository.Abstract;

namespace UniComparer.Repository
{
    public class GradeOfferRepository : IGradeOfferRepository
    {
        private readonly ApplicationDbContext context;
        public GradeOfferRepository(ApplicationDbContext context) => this.context = context;
        public ICollection<GradeOffer> GetGradeOffersByGradeId(int gradeId)
        {
            return context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade).ToList();
        }
        public GradeOffer GetGradeOffer(int gradeOfferId)
        {
            return context.GradeOffers.Where(go => go.IsActive && go.Id == gradeOfferId).Include(go => go.University).Include(go => go.Grade).Include(go => go.AcademicPeriodCategory)
                .FirstOrDefault();
        }
    }
}
