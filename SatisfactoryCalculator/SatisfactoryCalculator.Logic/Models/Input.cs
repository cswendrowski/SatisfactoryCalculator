using System.Diagnostics;

namespace SatisfactoryCalculator.Logic.Models
{
    [DebuggerDisplay("{Name} - {Amount}")]
    public class Input
    {
        public RecipeNames Name { get; set; }

        public int Amount { get; set; }
    }
}
