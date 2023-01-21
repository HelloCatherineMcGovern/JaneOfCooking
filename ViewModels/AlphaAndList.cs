using JoyceOfCooking.Models;
using System.Collections.Generic;

namespace JoyceOfCooking.ViewModels
{
    public class AlphaAndList
    {
        public string AlphaLetter { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public string RecipeTitle { get; set; } 
    }
}
