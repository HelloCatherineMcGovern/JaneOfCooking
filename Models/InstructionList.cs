using System.Collections.Generic;

namespace JoyceOfCooking.Models
{
    public class InstructionList
    {

        public int InstructionListId { get; set; }


        public virtual Recipe Recipe { get; set; }
        public ICollection<Instruction> Instructions { get; set; }

    }
}
