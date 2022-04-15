using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models.ViewModels
{
    public class ExerciseCategoryViewModel
    {
        public IEnumerable<Exercise> Exercises { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
    }
}
