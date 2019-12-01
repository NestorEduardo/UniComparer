using Microsoft.AspNetCore.Mvc;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGradeCategoryRepository gradeCategoryRepository;
        public HomeController(IGradeCategoryRepository gradeCategoryRepository)
        {
            this.gradeCategoryRepository = gradeCategoryRepository;
        }
        public IActionResult Index() => View(gradeCategoryRepository.GetGradeCategories());
    }
}