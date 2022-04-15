using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class ExerciseCategoryRelationship
    {
        public int ExerciseCategoryRelationshipId { get; set; }
        public int ExerciseId { get; set; }
        public int SecondaryCategoryId { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual SecondaryCategory SecondaryCategory {get;set;}
    }
}
