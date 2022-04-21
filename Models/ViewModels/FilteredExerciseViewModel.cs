using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models.ViewModels
{
    public class FilteredExerciseViewModel
    {
        public IEnumerable<SecondaryCategory> SecondaryCategories { get; set; }
        public IEnumerable<PrimaryTagViewModel> PrimaryTags { get; set; }
        public IEnumerable<SecondaryTagViewModel> SecondaryTags { get; set; }
        public IEnumerable<Type> Types { get; set; }
    }
}
