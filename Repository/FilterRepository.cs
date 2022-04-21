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
    public class FilterRepository : IFilterRepository
    {
        private readonly PowerFitContext _context;

        public FilterRepository(PowerFitContext context)
        {
            _context = context;
        }
        public Task<FilteredExerciseViewModel> FilteredExerciseViewModel(IEnumerable<SecondaryCategory> categories, IEnumerable<PrimaryTagViewModel> primaryTags, IEnumerable<SecondaryTagViewModel> secondaryTags, IEnumerable<Models.Type> types)
        {
            var vm = new FilteredExerciseViewModel
            {
                SecondaryCategories = categories,
                PrimaryTags = primaryTags,
                SecondaryTags = secondaryTags,
                Types = types
            };

            return Task.FromResult(vm);
        }

        public async Task<IEnumerable<Exercise>> GetFilteredExercisesAsync(string name, string englishName, int categoryid, int typeid, int primaryid, int secondaryid)
        {
            var exercises = (from e in _context.Exercises
                             join t in _context.Types on e.ExerciseTypeId equals t.TypeId
                             join ecr in _context.ExerciseCategoryRelationship on e.ExerciseId equals ecr.ExerciseId
                             join ec in _context.SecondaryCategories on ecr.SecondaryCategoryId equals ec.SecondaryCategoryId
                             join ptr in _context.PrimaryExerciseTagRelationship on e.ExerciseId equals ptr.ExerciseId
                             into primaryTagRelationshipTable
                             from ptr in primaryTagRelationshipTable.DefaultIfEmpty()
                             join pt in _context.ExerciseTag on ptr.TagId equals pt.ExerciseTagId
                             into primaryTag
                             from pt in primaryTag.DefaultIfEmpty()
                             join str in _context.SecondaryExerciseTagRelationship on e.ExerciseId equals str.ExerciseId
                             into secondaryTagRelationshipTable
                             from str in secondaryTagRelationshipTable.DefaultIfEmpty()
                             join st in _context.ExerciseTag on str.TagId equals st.ExerciseTagId
                             into secondaryTagTable
                             from st in secondaryTagTable.DefaultIfEmpty()
                             where e.IsDeleted == false
                             select new
                             {
                                 ExerciseId = e.ExerciseId,
                                 ExerciseName = e.ExerciseName,
                                 EnglishName = e.EnglishExerciseName,
                                 UpdateDate = e.UpdateDate,
                                 ExerciseTypeId = t.TypeId,
                                 ExererciseType = t.Name,
                                 ExerciseCategory = ec.Name,
                                 ExerciseCategoryId = ec.SecondaryCategoryId,
                                 PrimaryTag = pt.Name,
                                 PrimaryTagId = pt.ExerciseTagId,
                                 SecondaryTag = st.Name,
                                 SecondaryTagId = st.ExerciseTagId
                             }).Distinct();

            if (!string.IsNullOrEmpty(name))
            {
                exercises = exercises.Where(x => x.ExerciseName.Contains(name));
            }
            if (!string.IsNullOrEmpty(englishName))
            {
                exercises = exercises.Where(x => x.EnglishName.Contains(englishName));
            }
            if(categoryid != 0)
            {
                exercises = exercises.Where(x => x.ExerciseCategoryId == categoryid);
            }
            if(typeid != 0)
            {
                exercises = exercises.Where(x => x.ExerciseTypeId == typeid);
            }
            if(primaryid != 0)
            {
                exercises = exercises.Where(x => x.PrimaryTagId == primaryid);
            }
            if(secondaryid != 0)
            {
                exercises = exercises.Where(x => x.SecondaryTagId == secondaryid);
            }

            return await exercises.Select(e => new Exercise
            {
                ExerciseId = e.ExerciseId,
                ExerciseName = e.ExerciseName,
                EnglishExerciseName = e.EnglishName,
                UpdateDate = e.UpdateDate
            }).Distinct().ToListAsync();
        }

        public async Task<IEnumerable<PrimaryTagViewModel>> GetPrimaryTagsAsync()
        {
            var tags = _context.ExerciseTag.Select(t => new PrimaryTagViewModel { PrimaryTagId = t.ExerciseTagId, TagName = t.Name });

            return await tags.ToListAsync();
        }

        public async Task<IEnumerable<SecondaryCategory>> GetSecondaryCategoriesAsync()
        {
            var categories = _context.SecondaryCategories.Select(c => new SecondaryCategory { SecondaryCategoryId = c.SecondaryCategoryId, Name = c.Name });

            return await categories.ToListAsync();
        }

        public async Task<IEnumerable<SecondaryTagViewModel>> GetSecondaryTagsAsync()
        {
            var tags = _context.ExerciseTag.Select(t => new SecondaryTagViewModel { SecondaryTagId = t.ExerciseTagId, TagName = t.Name });

            return await tags.ToListAsync();
        }

        public async Task<IEnumerable<Models.Type>> GetTypesAsync()
        {
            var types = _context.Types.Select(t => new Models.Type { TypeId = t.TypeId, Name = t.Name, Description = t.Description });

            return await types.ToListAsync();
        }
    }
}
