using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class PrimaryExerciseTagRelationship
    {
        public int PrimaryExerciseTagRelationshipId { get; set; }
        public int TagId { get; set; }
        public int ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual ExerciseTag ExerciseTag { get; set; }
    }
}
