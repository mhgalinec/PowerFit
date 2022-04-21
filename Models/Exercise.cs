using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class Exercise
    {
        public Exercise()
        {
            ExerciseCategoryRelationship = new HashSet<ExerciseCategoryRelationship>();
            SecondaryExerciseTagRelationship = new HashSet<SecondaryExerciseTagRelationship>();
            PrimaryExerciseTagRelationship = new HashSet<PrimaryExerciseTagRelationship>();
            FavoriteExercise = new HashSet<FavoriteExercise>();
        }

        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string EnglishExerciseName { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public int ExerciseTypeId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }


        public virtual ICollection<ExerciseCategoryRelationship> ExerciseCategoryRelationship { get; set; }
        public virtual ICollection<SecondaryExerciseTagRelationship> SecondaryExerciseTagRelationship { get; set; }
        public virtual ICollection<PrimaryExerciseTagRelationship> PrimaryExerciseTagRelationship { get; set; }
        public virtual ICollection<FavoriteExercise> FavoriteExercise { get; set; }
        public virtual Type ExerciseType { get; set; }
    }
}
