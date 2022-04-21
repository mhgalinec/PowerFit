using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerFit.Models;
using PowerFit.Models.ViewModels;
using PowerFit.Repository.Interface;
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
        private readonly IFilterRepository _filterRepository;
        public HomeController(ILogger<HomeController> logger, PowerFitContext context,IExerciseRepository exerciseRepository, IFilterRepository filterRepository)
        {
            _logger = logger;
            _context = context;
            _exerciseRepository = exerciseRepository;
            _filterRepository = filterRepository;
        }

        public async Task<IActionResult> Index()
        {

            /*Get all the necessary data for the advanced filter form*/
            var types = await _filterRepository.GetTypesAsync();
            var categories = await _filterRepository.GetSecondaryCategoriesAsync();
            var primarytags = await _filterRepository.GetPrimaryTagsAsync();
            var secondaryTags = await _filterRepository.GetSecondaryTagsAsync();

            var filterViewModel = new FilteredExerciseViewModel
            {
                Types = types,
                SecondaryCategories =  categories,
                PrimaryTags =  primarytags,
                SecondaryTags =  secondaryTags
            };
            /**/

            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();
            var exercises = await _exerciseRepository.GetExercisesAsync();
            var categoryViewModel = new CategoryViewModel
            {
                PrimaryCategories = primaryCategories,
                SecondaryCategories = secondaryCategories
            };

            var viewmodel = new ExerciseCategoryViewModel
            {
                Exercises = exercises.Distinct(),
                CategoryViewModel = categoryViewModel,
                FilteredExerciseViewModel = filterViewModel

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
