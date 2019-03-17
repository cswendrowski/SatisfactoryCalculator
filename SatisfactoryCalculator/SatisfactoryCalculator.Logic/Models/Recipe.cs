using Humanizer;
using System.Collections.Generic;
using System.Diagnostics;

namespace SatisfactoryCalculator.Logic.Models
{
    [DebuggerDisplay("{HumanName}")]
    public class Recipe
    {
        public RecipeNames Name { get; set; }

        public string HumanName => Name.Humanize().Transform(To.TitleCase);

        public int CraftingTimePerItem { get; set; }

        public double ProducedPerMinute => 60 / CraftingTimePerItem;

        public string OutputPerMinuteString => $"{ProducedPerMinute} / minute";

        public Machines Machine { get; set; }

        public List<Input> Inputs { get; set; } = new List<Input>();
    }
}
