using System;
using System.Threading;
using SatisfactoryCalculator.Logic;
using SatisfactoryCalculator.Logic.Models;
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

            var timer = new Timer(OnTime);
        }

        private void OnTime(object state)
        {
            throw new NotImplementedException();
        }
    }
}
