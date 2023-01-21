using System.Collections.Generic;

namespace JoyceOfCooking.Models
{
    public class IngredientList
    {
        public int IngredientListId { get; set; }   
        public virtual Recipe Recipe { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
