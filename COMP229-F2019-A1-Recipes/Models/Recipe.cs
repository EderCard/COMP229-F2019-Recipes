using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_A1_Recipes.Models
{
    public class Recipe
    {
        public int Id{ get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Ingredients { get; set; }
        public String HowToCook { get; set; }
    }
}
