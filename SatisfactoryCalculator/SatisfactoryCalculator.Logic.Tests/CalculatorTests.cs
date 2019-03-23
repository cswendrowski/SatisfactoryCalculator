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

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(1.2d);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(2.4d);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(4.8d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(72);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(72d);
        }

        [Fact]
        public void CanCalculateModularFrame()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.ModularFrame);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(2.8d);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(5.6d);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(11.2d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(168);
            needs.TotalResourceNeeds[RecipeNames.IronIngot].ShouldBe(168);
        }

        [Fact]
        public void CanCalculateCable()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.Cable);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(0.5d);
            needs.TotalMachineNeeds[Machines.Smelter].ShouldBe(1d);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(3d);

            needs.TotalResourceNeeds[RecipeNames.CopperIngot].ShouldBe(30);
            needs.TotalResourceNeeds[RecipeNames.CopperOre].ShouldBe(30);
        }

        [Fact]
        public void CanCalculateConcrete()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.Concrete);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(.75d);
            needs.TotalMachineNeeds[Machines.Constructor].ShouldBe(1d);

            needs.TotalResourceNeeds[RecipeNames.Limestone].ShouldBe(45);
        }

        [Fact]
        public void CanCalculateSteelIngot()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.SteelIngot);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(1.5d);
            needs.TotalMachineNeeds[Machines.Foundry].ShouldBe(1d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(45);
            needs.TotalResourceNeeds[RecipeNames.Coal].ShouldBe(45);
        }

        [Fact]
        public void CanCalculateSteelBeam()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.SteelBeam);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(1.5d);
            needs.TotalMachineNeeds[Machines.Foundry].ShouldBe(1d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(45);
            needs.TotalResourceNeeds[RecipeNames.Coal].ShouldBe(45);
            needs.TotalResourceNeeds[RecipeNames.SteelIngot].ShouldBe(30);
        }

        [Fact]
        public void CanCalculateSteelPipe()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.SteelPipe);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(0.75d);
            needs.TotalMachineNeeds[Machines.Foundry].ShouldBe(0.5d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(22);
            needs.TotalResourceNeeds[RecipeNames.Coal].ShouldBe(22);
            needs.TotalResourceNeeds[RecipeNames.SteelIngot].ShouldBe(15);
        }

        [Fact]
        public void CanCalculateEncasedIndustrialBeam()
        {
            var recipe = RecipeBook.GetRecipe(RecipeNames.EncasedIndustrialBeam);

            var needs = RecipeCalculator.CalculateRecipeNeeds(recipe);

            needs.ShouldNotBeNull();
            needs.Inputs.ShouldNotBeEmpty();
            needs.TotalResourceNeeds.ShouldNotBeEmpty();
            needs.TotalMachineNeeds.ShouldNotBeEmpty();

            needs.TotalMachineNeeds[Machines.Miner].ShouldBe(3.4d);

            needs.TotalResourceNeeds[RecipeNames.IronOre].ShouldBe(72);
            needs.TotalResourceNeeds[RecipeNames.Coal].ShouldBe(72);
        }
    }
}
