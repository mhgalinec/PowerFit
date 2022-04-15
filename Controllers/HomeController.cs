using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerFit.Migrations;
using PowerFit.Models;
using PowerFit.Models.ViewModels;
using PowerFit.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PowerFitContext _context;
        private readonly IExerciseRepository _exerciseRepository;

        public HomeController(ILogger<HomeController> logger, PowerFitContext context,IExerciseRepository exerciseRepository)
        {
            _logger = logger;
            _context = context;
            _exerciseRepository = exerciseRepository;
        }

        public async Task<IActionResult> Index()
        {
            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();
            var exercises = await _exerciseRepository.GetExercisesAsync();
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
