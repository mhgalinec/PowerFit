using PowerFit.Models;
using PowerFit.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Repository.Interface
{
    public interface IExerciseRepository
    {
        public Task<IEnumerable<Exercise>> GetExercisesByCategoryIdAsync(int id);
        public Task<IEnumerable<Exercise>> GetExercisesAsync();
        public Task<IEnumerable<PrimaryCategory>> GetPrimaryCategoriesAsync();
        public Task<IEnumerable<SecondaryCategory>> GetSecondaryCategoriesAsync();
        public Task<IEnumerable<Exercise>> GetExercisesBySearchParameterAsync(string term);
        public Task<ExerciseViewModel> GetExerciseDetailsAsync(int id);
        public Exercise CreateExercise(CreateExerciseViewModel model);
    }
}
