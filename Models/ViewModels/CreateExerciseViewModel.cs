using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models.ViewModels
{
    public class CreateExerciseViewModel
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string EnglishExerciseName { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public IEnumerable<int> Categories { get; set; }
        public IEnumerable<int> PrimaryTags { get; set; }
        public IEnumerable<int> SecondaryTags { get; set; }
    }
}
