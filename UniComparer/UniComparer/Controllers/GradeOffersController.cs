using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Models.ViewModels;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradeOffersController : Controller
    {
        private readonly IGradeOfferRepository gradeOfferRepository;
        private readonly ICampusRepository campusRepository;
        private int pageSize = 1;
        public GradeOffersController(IGradeOfferRepository gradeOfferRepository, ICampusRepository campusRepository)
        {
            this.gradeOfferRepository = gradeOfferRepository;
            this.campusRepository = campusRepository;
        }
        public IActionResult GradeOffersByGrade(int gradeId, int page = 1)
        {
            int skip = (page - 1) * pageSize;
            ICollection<GradeOffer> gradeOffers = gradeOfferRepository.GetGradeOffersByGradeId(gradeId);

            GradeOfferByGradeViewModel gradeOfferByGradeViewModel = new GradeOfferByGradeViewModel
            {
                GradeOffers = gradeOffers.Skip(skip).Take(pageSize).ToList(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)gradeOffers.Count / pageSize)
        };

            return View(gradeOfferByGradeViewModel);
        }
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