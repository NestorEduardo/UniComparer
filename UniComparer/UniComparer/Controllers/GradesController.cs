using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniComparer.Models;
using UniComparer.Models.ViewModels;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradesController : Controller
    {
        private readonly IGradeRepository gradeRepository;
        public GradesController(IGradeRepository gradeRepository)
        {
            this.gradeRepository = gradeRepository;
        }
        public IActionResult GradesByGradeCategory(int gradeCategoryId, string search = "", bool partialView = false)
        {
           GradesByGradeCategoryViewModel gradesByGradeCategoryViewModel = new GradesByGradeCategoryViewModel();

            if (string.IsNullOrEmpty(search))
            {
                gradesByGradeCategoryViewModel.Grades = gradeRepository.GetGradesByGradeCategoryId(gradeCategoryId);
            }
            else
            {
                gradesByGradeCategoryViewModel.Grades = gradeRepository.GetGradesByGradeCategoryId(gradeCategoryId, search);
            }

            if (!partialView)
            {
                return View(gradesByGradeCategoryViewModel);
            }
            else
            {
                return PartialView("_GradesList", gradesByGradeCategoryViewModel);
            }
        }
    }
}