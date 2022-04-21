using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models
{
    public partial class Type
    {
        public Type()
        {
            Exercises = new HashSet<Exercise>();
        }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
