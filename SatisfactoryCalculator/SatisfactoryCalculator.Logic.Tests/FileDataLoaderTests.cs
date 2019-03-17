using Shouldly;
using System.Linq;
using Xunit;

namespace SatisfactoryCalculator.Logic.Tests
{
    public class FileDataLoaderTests
    {
        [Fact]
        public void CanLoadRecipe()
        {
            var iron = FileDataLoader.LoadRecipe("Iron Ingot");

            iron.ShouldNotBeNull();
            iron.Name.ShouldBe("Iron Ingot");
            iron.OutputPerMinute.ShouldBe(60);
            iron.Inputs.ShouldNotBeEmpty();
            iron.Inputs.First().Name.ShouldBe("Iron Ore");
        }
    }
}
