using System.Diagnostics;

namespace SatisfactoryCalculator.Logic.Models
{
    [DebuggerDisplay("{Name} - {InputPerMinute} / m")]
    public class Input
    {
        public RecipeNames Name { get; set; }

        public int InputPerMinute { get; set; }
    }
}
