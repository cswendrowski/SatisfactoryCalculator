using System.Collections.Generic;

namespace SatisfactoryCalculator.Logic.Models
{
    public class RecipeNeeds
    {
        public List<Input> Inputs { get; set; } = new List<Input>();

        public Dictionary<RecipeNames, int> TotalResourceNeeds { get; set; } = new Dictionary<RecipeNames, int>();

        public Dictionary<Machines, int> TotalMachineNeeds { get; set; } = new Dictionary<Machines, int>();
    }
}
