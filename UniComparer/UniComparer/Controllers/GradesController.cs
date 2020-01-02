using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Models.ViewModels;
using UniComparer.Repository.Abstract;

namespace UniComparer.Controllers
{
    public class GradesController : Controller
    {
        private readonly IGradeRepository gradeRepository;
        private int pageSize = 1;
        public GradesController(IGradeRepository gradeRepository)
        {
            this.gradeRepository = gradeRepository;
        }
        public IActionResult GradesByGradeCategory(int gradeCategoryId, string search = "", bool partialView = false, int page = 1)
        {
            int skip = (page - 1) * pageSize;
            
            GradesByGradeCategoryViewModel gradesByGradeCategoryViewModel = new GradesByGradeCategoryViewModel
            {
                CurrentPage = page,
                Search = search
            };

            if (string.IsNullOrEmpty(search))
            {
                gradesByGradeCategoryViewModel.Grades = gradeRepository.GetGradesByGradeCategoryId(gradeCategoryId);
            }
            else
            {
                gradesByGradeCategoryViewModel.Grades = gradeRepository.GetGradesByGradeCategoryId(gradeCategoryId, search);
            }

            gradesByGradeCategoryViewModel.TotalPages = (int)Math.Ceiling((double)gradesByGradeCategoryViewModel.Grades.Count / pageSize);
            gradesByGradeCategoryViewModel.Grades = gradesByGradeCategoryViewModel.Grades.Skip(skip).Take(pageSize).ToList();

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