using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Models.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<PrimaryCategory> PrimaryCategories { get; set; }
        public IEnumerable<SecondaryCategory> SecondaryCategories { get; set; }
    }
}
