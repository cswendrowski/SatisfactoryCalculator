using SatisfactoryCalculator.Blazor;
using SatisfactoryCalculator.Blazor.Models;
using Shouldly;
using Xunit;

namespace SatisfactoryCalculator.Logic.Tests
{
    public class FuelTests
    {
        [Fact]
        public void CanCalculateFuelRemaining()
        {
            var fuel = FuelBook.GetRecipe(FuelNames.Leaves);

            fuel.GetRemainingSeconds(1).ShouldBe(0.75);
            fuel.GetRemainingSeconds(10).ShouldBe(7.5);
        }
    }
}
