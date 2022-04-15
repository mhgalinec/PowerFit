using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class PrimaryCategory
    {
        public PrimaryCategory()
        {
            ExerciseCategories = new HashSet<SecondaryCategory>();
        }
        public int PrimaryCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SecondaryCategory> ExerciseCategories{ get; set; }
    }
}
