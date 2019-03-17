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

        public int OutputPerMinute { get; set; }

        public string OutputPerMinuteString => $"{OutputPerMinute} / minute";

        public Machines Machine { get; set; }

        public List<Input> Inputs { get; set; } = new List<Input>();
    }
}
