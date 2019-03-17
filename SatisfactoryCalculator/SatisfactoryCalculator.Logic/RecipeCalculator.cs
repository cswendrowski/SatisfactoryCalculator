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

        private static void AddInputNeeds(Recipe recipe, RecipeNeeds needs)
        {
            if (!needs.TotalMachineNeeds.ContainsKey(recipe.Machine))
            {
                needs.TotalMachineNeeds[recipe.Machine] = 0;
            }
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
                    needs.TotalResourceNeeds[input.Name] += input.InputPerMinute;

                    AddInputNeeds(RecipeBook.GetRecipe(input.Name), needs);
                }
            }
        }
    }
}
