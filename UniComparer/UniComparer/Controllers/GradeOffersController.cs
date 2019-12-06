using Microsoft.AspNetCore.Mvc;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradeOffersController : Controller
    {
        private readonly IGradeOfferRepository gradOfferRepository;
        public GradeOffersController(IGradeOfferRepository gradOfferRepository)
        {
            this.gradOfferRepository = gradOfferRepository;
        }
        public IActionResult GradeOffersByGrade(int gradeId) => View(gradOfferRepository.GetGradeOffersByGradeId(gradeId));
    }
}