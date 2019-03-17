using System.Collections.Generic;

namespace SatisfactoryCalculator.Logic.Models
{
    public class RecipeNeeds
    {
        public List<Input> Inputs { get; set; } = new List<Input>();

        public Dictionary<RecipeNames, double> TotalResourceNeeds { get; set; } = new Dictionary<RecipeNames, double>();

        public Dictionary<Machines, double> TotalMachineNeeds { get; set; } = new Dictionary<Machines, double>();
    }
}
