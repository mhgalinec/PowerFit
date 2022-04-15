using Microsoft.EntityFrameworkCore;
using PowerFit.Models;
using PowerFit.Models.ViewModels;
using PowerFit.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Repository
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly PowerFitContext _context;

        public ExerciseRepository(PowerFitContext context)
        {
            _context = context;
        }

        public async Task<ExerciseViewModel> GetExerciseDetailsAsync(int id)
        {
            var primaryTags = await (from e in _context.Exercises
                               join ptr in _context.PrimaryExerciseTagRelationship on e.ExerciseId equals ptr.ExerciseId
                               join pt in _context.ExerciseTag on ptr.TagId equals pt.ExerciseTagId
                               where e.ExerciseId == id
                               select new PrimaryTagViewModel
                               {
                                   ExerciseId = e.ExerciseId,
                                   TagName = pt.Name,
                                   PrimaryTagId = pt.ExerciseTagId
                               }).ToListAsync();

            var secondaryTags = await (from e in _context.Exercises
                                 join str in _context.SecondaryExerciseTagRelationship on e.ExerciseId equals str.ExerciseId
                                 join st in _context.ExerciseTag on str.TagId equals st.ExerciseTagId
                                 where e.ExerciseId == id
                                 select new SecondaryTagViewModel
                                 {
                                     ExerciseId = e.ExerciseId,
                                     SecondaryTagId = st.ExerciseTagId,
                                     TagName = st.Name
                                 }
                                 ).ToListAsync();
            var exercise = (from e in _context.Exercises
                            where e.ExerciseId == id
                            select new ExerciseViewModel
                            {
                                ExerciseId = e.ExerciseId,
                                ExerciseName = e.ExerciseName,
                                EnglishExerciseName = e.EnglishExerciseName,
                                Description = e.Description,
                                PrimaryTags = primaryTags,
                                SecondaryTags = secondaryTags
                            });

            return await exercise.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Exercise>> GetExercisesAsync()
        {
            var exercises = (from e in _context.Exercises
                             select new Exercise
                             {
                                 ExerciseId = e.ExerciseId,
                                 ExerciseName = e.ExerciseName,
                                 EnglishExerciseName = e.EnglishExerciseName,
                                 Description = e.Description,
                                 InsertDate = e.InsertDate
                             });

            return await exercises.ToListAsync();
        }

        public async Task<IEnumerable<Exercise>> GetExercisesByCategoryIdAsync(int id)
        {
            var exercises = (from e in _context.Exercises
                             join ecr in _context.ExerciseCategoryRelationship on e.ExerciseId equals ecr.ExerciseId
                             join ec in _context.SecondaryCategories on ecr.SecondaryCategoryId equals ec.SecondaryCategoryId
                             where ec.SecondaryCategoryId == id
                             select new Exercise
                             {
                                 ExerciseId = e.ExerciseId,
                                 ExerciseName = e.ExerciseName,
                                 EnglishExerciseName = e.EnglishExerciseName,
                                 Description = e.Description

                             });

            return await exercises.ToListAsync();
        }

        public async Task<IEnumerable<Exercise>> GetExercisesBySearchParameterAsync(string term)
        {
            var exercise = (from e in _context.Exercises
                            where e.ExerciseName.Contains(term) || e.EnglishExerciseName.Contains(term)
                            select new Exercise
                            {
                                ExerciseId = e.ExerciseId,
                                EnglishExerciseName = e.EnglishExerciseName,
                                ExerciseName = e.ExerciseName,
                                Description = e.Description
                            });
            return await exercise.ToListAsync();
        }

        public async Task<IEnumerable<PrimaryCategory>> GetPrimaryCategoriesAsync()
        {
            var primaryCategories = _context.PrimaryCategories.Select(m => new PrimaryCategory
            {
                PrimaryCategoryId = m.PrimaryCategoryId,
                Name = m.Name
            });

            return await primaryCategories.ToListAsync();
        }

        public async Task<IEnumerable<SecondaryCategory>> GetSecondaryCategoriesAsync()
        {
            var secondaryCategories = (from sc in _context.SecondaryCategories
                                       join pc in _context.PrimaryCategories on sc.PrimaryCategoryId equals pc.PrimaryCategoryId
                                       select new SecondaryCategory
                                       {
                                           SecondaryCategoryId = sc.SecondaryCategoryId,
                                           Name = sc.Name,
                                           PrimaryCategoryId = sc.PrimaryCategoryId
                                       });

            return await secondaryCategories.ToListAsync();
        }
    }
}
