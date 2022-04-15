using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class FavoriteExercise
    {
        public int FavoriteExerciseId { get; set; }
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public DateTime InsertDate { get; set; }
        

        public virtual Exercise Exercise { get; set; }
        public virtual User User { get; set; }
    }
}
