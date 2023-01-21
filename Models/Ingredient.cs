

namespace JoyceOfCooking.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }  
        public string IngredientText { get; set; }
        public int IngredientListId { get; set; }  //Foreign Key
        public virtual IngredientList IngredientList { get; set; }
    }
}
