using System.Collections.Generic;

namespace SatisfactoryCalculator.Logic.Models
{
    public class RecipeNeeds
    {
        public List<Input> Inputs { get; set; } = new List<Input>();

        public Dictionary<string, int> TotalResourceNeeds { get; set; } = new Dictionary<string, int>();
    }
}
