using Microsoft.AspNetCore.Mvc;
using PowerFit.Models;
using PowerFit.Models.ViewModels;
using PowerFit.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly PowerFitContext _context;
        private readonly IExerciseRepository _exerciseRepository;

        public ExercisesController(PowerFitContext context,IExerciseRepository exerciseRepository)
        {
            _context = context;
            _exerciseRepository = exerciseRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(int id,string term)
        {
            ViewData["SearchParam"] = _context.SecondaryCategories.Where(s => s.SecondaryCategoryId == id).Select(s => s.Name).SingleOrDefault();
            ViewData["SearchTerm"] = term;
            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();
            var exercises = await _exerciseRepository.GetExercisesBySearchParameterAsync(term);
            if(id != 0)
            {
                exercises = await _exerciseRepository.GetExercisesByCategoryIdAsync(id);
            } 

            var vm = new CategoryViewModel
            {
                PrimaryCategories = primaryCategories,
                SecondaryCategories = secondaryCategories
            };

            var viewmodel = new ExerciseCategoryViewModel
            {
                Exercises = exercises.Distinct(),
                CategoryViewModel = vm

            };
            return View(viewmodel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();

            var vm = new CategoryViewModel
            {
                PrimaryCategories = primaryCategories,
                SecondaryCategories = secondaryCategories
            };

            var exercises = await _exerciseRepository.GetExerciseDetailsAsync(id);
            return View(exercises);
        }
    }
}
