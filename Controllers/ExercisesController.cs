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

        public ExercisesController(PowerFitContext context,IExerciseRepository exerciseRepository,IImageRepository img)
        {
            _context = context;
            _exerciseRepository = exerciseRepository;
            _img = img;
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
