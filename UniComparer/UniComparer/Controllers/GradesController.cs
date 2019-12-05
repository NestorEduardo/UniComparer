using Microsoft.AspNetCore.Mvc;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradesController : Controller
    {
        private readonly IGradeRepository gradRepository;
        public GradesController(IGradeRepository gradRepository)
        {
            this.gradRepository = gradRepository;
        }
        public IActionResult GradesByGradeCategory(int gradeCategoryId) => View(gradRepository.GetGradesByGradeCategoryId(gradeCategoryId));
    }
}