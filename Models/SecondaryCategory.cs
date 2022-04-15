using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class SecondaryCategory
    {
        public SecondaryCategory()
        {
            ExerciseCategoryRelationship = new HashSet<ExerciseCategoryRelationship>();
        }

        public int SecondaryCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrimaryCategoryId { get; set; }


        public virtual PrimaryCategory PrimaryCategory { get; set; }
        public virtual ICollection<ExerciseCategoryRelationship> ExerciseCategoryRelationship { get; set; }
        
    }
}
