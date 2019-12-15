using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Repository.Abstract;
using UniComparer.Utils;

namespace UniComparer.Repository
{
    public class GradeOfferRepository : IGradeOfferRepository
    {
        private readonly ApplicationDbContext context;
        public GradeOfferRepository(ApplicationDbContext context) => this.context = context;
        public ICollection<GradeOffer> GetGradeOffersByGradeId(int gradeId, GradeOfferSortingOptions gradeOfferSortingOption)
        {
            ICollection<GradeOffer> gradeOffers = new List<GradeOffer>();

            if (gradeOfferSortingOption == GradeOfferSortingOptions.None)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                    .ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoInscripcionMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                    .OrderByDescending(g => g.InscriptionPrice).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoInscripcionMenorMayor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                    .OrderBy(g => g.InscriptionPrice).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoCreditosMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                  .OrderByDescending(g => g.CreditsPrice).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoCreditosMenorMayor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
               .OrderBy(g => g.CreditsPrice).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoCarreraMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                  .OrderByDescending(g => g.Cost).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CostoCarreraMenorMayor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
               .OrderBy(g => g.Cost).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CantidadCreditosMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                  .OrderByDescending(g => g.CreditsNumber).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.CantidadCreditosMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
               .OrderBy(g => g.CreditsNumber).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.DuracionCarreraMayorMenor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
                  .OrderByDescending(g => g.MonthsDuration).ToList();
            }
            else if (gradeOfferSortingOption == GradeOfferSortingOptions.DuracionCarreraMenorMayor)
            {
                gradeOffers = context.GradeOffers.Where(go => go.IsActive && go.GradeId == gradeId).Include(go => go.AcademicPeriodCategory).Include(go => go.University).Include(g => g.Grade)
               .OrderBy(g => g.MonthsDuration).ToList();
            }

            return gradeOffers;
        }
        public GradeOffer GetGradeOffer(int gradeOfferId)
        {
            return context.GradeOffers.Where(go => go.IsActive && go.Id == gradeOfferId).Include(go => go.University).Include(go => go.Grade).Include(go => go.AcademicPeriodCategory)
                .FirstOrDefault();
        }
    }
}
