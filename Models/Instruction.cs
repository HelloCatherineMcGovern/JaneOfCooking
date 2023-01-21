namespace JoyceOfCooking.Models
{
    public class Instruction
    {
        public int InstructionId { get; set; }
        public string InstructionText { get; set; }
        public int InstructionListId { get; set; }  //Foreign KEY (RecipeID) References Recipe List
        public virtual InstructionList InstructionList { get; set; }    
    }
}

