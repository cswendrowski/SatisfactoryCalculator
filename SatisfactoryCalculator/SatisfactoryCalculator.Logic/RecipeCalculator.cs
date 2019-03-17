using SatisfactoryCalculator.Logic.Models;
using System.Linq;

namespace SatisfactoryCalculator.Logic
{
    public static class RecipeCalculator
    {
        public static RecipeNeeds CalculateRecipeNeeds(Recipe recipe)
        {
            var needs = new RecipeNeeds();

            AddInputNeeds(recipe, needs);

            return needs;
        }

        private static void AddInputNeeds(Recipe recipe, RecipeNeeds needs, double ratio = 1.00)
        {
            if (!needs.TotalMachineNeeds.ContainsKey(recipe.Machine))
            {
                needs.TotalMachineNeeds[recipe.Machine] = 0;
            }
            // TODO: Only add the % of the machine needed such as .5 of a Miner's output
            needs.TotalMachineNeeds[recipe.Machine]++;

            if (recipe.Inputs.Any())
            {
                needs.Inputs.AddRange(recipe.Inputs);
                foreach (var input in recipe.Inputs)
                {
                    if (!needs.TotalResourceNeeds.ContainsKey(input.Name))
                    {
                        needs.TotalResourceNeeds[input.Name] = 0;
                    }
                    var inputNeeds = input.Amount * recipe.ProducedPerMinute * ratio;
                    needs.TotalResourceNeeds[input.Name] += inputNeeds;

                    var inputRecipe = RecipeBook.GetRecipe(input.Name);
                    AddInputNeeds(inputRecipe, needs, inputNeeds / inputRecipe.ProducedPerMinute);
                }
            }
        }
    }
}
