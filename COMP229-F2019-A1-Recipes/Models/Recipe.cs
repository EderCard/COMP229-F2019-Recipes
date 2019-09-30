using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace COMP229_F2019_A1_Recipes.Models
{
    public class Recipe
    {
        public String Category{ get; set; }
        public String Name { get; set; }
        public String Ingredients { get; set; }
        public String HowToCook { get; set; }
        public String Picture { get; set; }
        public int Rate { get; set; }
        public String Comment { get; set; }
    }

}
