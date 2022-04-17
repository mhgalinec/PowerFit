﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models.ViewModels
{
    public class ExerciseViewModel
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string EnglishExerciseName { get; set; }
        public string Description { get; set; }
        public DateTime? UpdateDate { get; set; }
        public IFormFile Image { get; set; }
        public IEnumerable<PrimaryTagViewModel> PrimaryTags { get; set; }
        public IEnumerable<SecondaryTagViewModel> SecondaryTags { get; set; }
    }
}
