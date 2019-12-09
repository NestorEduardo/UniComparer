using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniComparer.Models;
using UniComparer.Models.ViewModels;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradeOffersController : Controller
    {
        private readonly IGradeOfferRepository gradeOfferRepository;
        private readonly ICampusRepository campusRepository;
        public GradeOffersController(IGradeOfferRepository gradeOfferRepository, ICampusRepository campusRepository)
        {
            this.gradeOfferRepository = gradeOfferRepository;
            this.campusRepository = campusRepository;
        }
        public IActionResult GradeOffersByGrade(int gradeId) => View(gradeOfferRepository.GetGradeOffersByGradeId(gradeId));
        public IActionResult GradeOfferDetails(int gradeOfferId)
        {

            GradeOffer gradeOffer = gradeOfferRepository.GetGradeOffer(gradeOfferId);
            ICollection<Campus> campus = campusRepository.GetCampusByUniversity(gradeOffer.University.Id);

            GradeOfferDetailsViewModel gradeOfferDetailsViewModel = new GradeOfferDetailsViewModel
            {
                Campus = campus,
                GradeOffer = gradeOffer
            };

            return View(gradeOfferDetailsViewModel);
        }
    }
}