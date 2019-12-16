using Microsoft.AspNetCore.Mvc;
using UniComparer.Models.ViewModels;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGradeCategoryRepository gradeCategoryRepository;
        private readonly IGradeOfferRepository gradeOfferRepository;
        private readonly IGradeRepository gradeRepository;
        private readonly IUniversityRepository universityRepository;
        public HomeController(IGradeCategoryRepository gradeCategoryRepository, IGradeOfferRepository gradeOfferRepository, IGradeRepository gradeRepository,
            IUniversityRepository universityRepository)
        {
            this.gradeCategoryRepository = gradeCategoryRepository;
            this.gradeOfferRepository = gradeOfferRepository;
            this.gradeRepository = gradeRepository;
            this.universityRepository = universityRepository;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                GradeCategories = gradeCategoryRepository.GetGradeCategories(),
                GradeOffersCount = gradeOfferRepository.GetGradeOffersCount(),
                GradesCount = gradeRepository.GetGradesCount(),
                UniversitiesCount = universityRepository.GetUniversitiesCount()
            };

            return View(homeViewModel);
        }
    }
}