using PowerFit.Models;
using PowerFit.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Repository.Interface
{
    public interface IFilterRepository
    {
        public Task<IEnumerable<SecondaryCategory>> GetSecondaryCategoriesAsync();
        public Task<IEnumerable<PrimaryTagViewModel>> GetPrimaryTagsAsync();
        public Task<IEnumerable<SecondaryTagViewModel>> GetSecondaryTagsAsync();
        public Task<IEnumerable<Models.Type>> GetTypesAsync();
        public Task<FilteredExerciseViewModel> FilteredExerciseViewModel(IEnumerable<SecondaryCategory> categories, IEnumerable<PrimaryTagViewModel> primaryTags, IEnumerable<SecondaryTagViewModel> secondaryTags, IEnumerable<Models.Type> types);
        public Task<IEnumerable<Exercise>> GetFilteredExercisesAsync(string name, string englishName, int categoryid, int typeid, int primaryid, int secondaryid);
    }
}
