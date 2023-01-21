namespace JoyceOfCooking.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; } 
        public string RecipeName { get; set; }

        public int IngredientListId { get; set; }
        public virtual IngredientList IngredientList { get; set; }

        public int InstructionListId { get; set; }
        public virtual InstructionList InstructionList { get; set; }

    }

}
