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
        private readonly IImageRepository _img;
        private readonly IFilterRepository _filterRepository;

        public ExercisesController(PowerFitContext context,IExerciseRepository exerciseRepository,IImageRepository img, IFilterRepository filterRepository)
        {
            _context = context;
            _exerciseRepository = exerciseRepository;
            _img = img;
            _filterRepository = filterRepository;
        }
        public async Task<IActionResult> Index()
        {
            var types = _filterRepository.GetTypesAsync();
            var categories = _filterRepository.GetSecondaryCategoriesAsync();
            var primarytags = _filterRepository.GetPrimaryTagsAsync();
            var secondaryTags = _filterRepository.GetSecondaryTagsAsync();

            var vm = new FilteredExerciseViewModel
            {
                Types = await types,
                SecondaryCategories = await categories,
                PrimaryTags = await primarytags,
                SecondaryTags = await secondaryTags
            };
            return View(vm);
        }

        public async Task<IActionResult> Search(int id,string term)
        {
            var types = await _filterRepository.GetTypesAsync();
            var categories = await _filterRepository.GetSecondaryCategoriesAsync();
            var primarytags = await _filterRepository.GetPrimaryTagsAsync();
            var secondaryTags = await _filterRepository.GetSecondaryTagsAsync();

            var filterViewModel = new FilteredExerciseViewModel
            {
                Types = types,
                SecondaryCategories = categories,
                PrimaryTags = primarytags,
                SecondaryTags = secondaryTags
            };

            ViewData["SearchParam"] = _context.SecondaryCategories.Where(s => s.SecondaryCategoryId == id).Select(s => s.Name).SingleOrDefault();
            ViewData["SearchTerm"] = term;
            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();
            var exercises = await _exerciseRepository.GetExercisesBySearchParameterAsync(term);
            if(id != 0)
            {
                exercises = await _exerciseRepository.GetExercisesByCategoryIdAsync(id);
            }

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

        [HttpGet]
        [ActionName("FilteredSearch")]
        public async Task<IActionResult> Search(string name, string englishName, int categoryid, int typeid, int primaryid, int secondaryid)
        {
            var categoryTerm = _context.SecondaryCategories.Where(c => c.SecondaryCategoryId == categoryid).Select(c => c.Name).FirstOrDefault();
            var typeTerm = _context.Types.Where(t => t.TypeId == typeid).Select(t => t.Name).FirstOrDefault();
            var primarytagTerm = _context.ExerciseTag.Where(t => t.ExerciseTagId == primaryid).Select(t => t.Name).FirstOrDefault();
            var secondarytagTerm = _context.ExerciseTag.Where(t => t.ExerciseTagId == secondaryid).Select(t => t.Name).FirstOrDefault();


            string[] searchTerms = { name, englishName, categoryTerm, typeTerm, primarytagTerm, secondarytagTerm};
            var str = String.Join(",", searchTerms.Where(s => !string.IsNullOrEmpty(s)));

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(englishName))
            {
                ViewData["FilterTerms"] = "svi proizvodi";
            }

            ViewData["FilterTerms"] = str.ToLower();

            var types = await _filterRepository.GetTypesAsync();
            var categories = await _filterRepository.GetSecondaryCategoriesAsync();
            var primarytags = await _filterRepository.GetPrimaryTagsAsync();
            var secondaryTags = await _filterRepository.GetSecondaryTagsAsync();

            var filterViewModel = new FilteredExerciseViewModel
            {
                Types = types,
                SecondaryCategories = categories,
                PrimaryTags = primarytags,
                SecondaryTags = secondaryTags
            };


            var primaryCategories = await _exerciseRepository.GetPrimaryCategoriesAsync();
            var secondaryCategories = await _exerciseRepository.GetSecondaryCategoriesAsync();

            var categoryViewModel = new CategoryViewModel
            {
                PrimaryCategories = primaryCategories,
                SecondaryCategories = secondaryCategories
            };

            var exercises = await _filterRepository.GetFilteredExercisesAsync(name, englishName, categoryid, typeid, primaryid, secondaryid);

            var viewmodel = new ExerciseCategoryViewModel
            {
                Exercises = exercises,
                CategoryViewModel = categoryViewModel,
                FilteredExerciseViewModel = filterViewModel

            };
            return View("Search",viewmodel);
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

        [HttpGet]
        public IActionResult Add()
        {
            var primaryTags = _context.ExerciseTag.Select(p => new PrimaryTagViewModel { PrimaryTagId = p.ExerciseTagId, TagName = p.Name }).ToList();
            ViewData["PrimaryTags"] = primaryTags;

            var secondaryTags = _context.ExerciseTag.Select(p => new SecondaryTagViewModel { SecondaryTagId = p.ExerciseTagId, TagName = p.Name }).ToList();
            ViewData["SecondaryTags"] = secondaryTags;

            var categories = _context.SecondaryCategories.Select(c => new SecondaryCategory { SecondaryCategoryId = c.SecondaryCategoryId, Name = c.Name }).ToList();
            ViewData["Categories"] = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(CreateExerciseViewModel model)
        {
            var exercise = _exerciseRepository.CreateExercise(model);
            try
            {
                _context.Exercises.Add(exercise);
                _context.SaveChanges();

                foreach(var t in model.PrimaryTags)
                {
                    var primaryTagsRelationship = new PrimaryExerciseTagRelationship { ExerciseId = exercise.ExerciseId, TagId = t };
                    _context.PrimaryExerciseTagRelationship.Add(primaryTagsRelationship);
                    
                }
                foreach (var t in model.SecondaryTags)
                {
                    var secondaryTagsRelationship = new SecondaryExerciseTagRelationship { ExerciseId = exercise.ExerciseId, TagId = t };
                    _context.SecondaryExerciseTagRelationship.Add(secondaryTagsRelationship);

                }
                foreach(var c in model.Categories)
                {
                    var exerciseCategoryRelationship = new ExerciseCategoryRelationship { ExerciseId = exercise.ExerciseId, SecondaryCategoryId = c };
                    _context.ExerciseCategoryRelationship.Add(exerciseCategoryRelationship);
                }

                _context.SaveChanges();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
