using System.Diagnostics;

namespace SatisfactoryCalculator.Logic.Models
{
    [DebuggerDisplay("{Name} - {Amount}")]
    public class Input
    {
        public RecipeNames Name { get; set; }

        public float Amount { get; set; }

        public string DisplayString => $"{Name}: {Amount}";
    }
}
