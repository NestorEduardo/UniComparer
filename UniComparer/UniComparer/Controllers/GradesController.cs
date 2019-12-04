using Microsoft.AspNetCore.Mvc;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradesController : Controller
    {
        private readonly IGradeRepository gradeCategoryRepository;
        public GradesController(IGradeRepository gradeCategoryRepository)
        {
            this.gradeCategoryRepository = gradeCategoryRepository;
        }
        public IActionResult GradesByGradeCategory()
        {
            return View();
        }
    }
}