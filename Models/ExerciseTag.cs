using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class ExerciseTag
    {
        public ExerciseTag()
        {
            PrimaryExerciseTagRelationship = new HashSet<PrimaryExerciseTagRelationship>();
            SecondaryExerciseTagRelationship = new HashSet<SecondaryExerciseTagRelationship>();
        }

        public int ExerciseTagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PrimaryExerciseTagRelationship> PrimaryExerciseTagRelationship { get; set; }
        public virtual ICollection<SecondaryExerciseTagRelationship> SecondaryExerciseTagRelationship { get; set; }
    }
}
