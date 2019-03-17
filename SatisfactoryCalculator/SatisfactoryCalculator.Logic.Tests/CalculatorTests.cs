using SatisfactoryCalculator.Logic.Models;
using Shouldly;
using Xunit;

namespace SatisfactoryCalculator.Logic.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CanCalculateOre()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.IronOre);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldBeEmpty();
            needs.TotalResourceNeeds.ShouldBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(1);
        }

        [Fact]
        public void CanCalculateIngot()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.IronIngot);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.5);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(1);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(30);
        }

        [Fact]
        public void CanCalculatePlate()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.IronPlate);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.5);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(1);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(1);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(30);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(30);
        }

        [Fact]
        public void CanCalculateRod()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.IronRod);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.25);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(.5);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(1);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(15);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(15);
        }

        [Fact]
        public void CanCalculateReinforcedIronPlate()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.ReinforcedIronPlate);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(15);

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.25);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(.5);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(1);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(15);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(15);
        }

        [Fact]
        public void CanCalculateModularFramed()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.ModularFrame);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(15);

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.25);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(.5);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(1);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(15);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(15);
        }
    }
}
