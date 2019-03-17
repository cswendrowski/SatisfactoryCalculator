using SatisfactoryCalculator.Logic.Models;
using System.Collections.Generic;

namespace SatisfactoryCalculator.Logic
{
    public static class RecipeBook
    {
        private static Dictionary<RecipeNames, Recipe> _book = new Dictionary<RecipeNames, Recipe>();

        static RecipeBook()
        {
            LoadIron();
        }

        public static Recipe GetRecipe(RecipeNames name)
        {
            return _book[name];
        }

        private static void AddToBook(Recipe recipe)
        {
            _book.Add(recipe.Name, recipe);
        }

        private static void LoadIron()
        {
            AddToBook(new Recipe
            {
                Name = RecipeNames.IronOre,
                CraftingTimePerItem = 1,
                Machine = Machines.Miner,
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronIngot,
                CraftingTimePerItem = 2,
                Machine = Machines.Smelter,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronOre, Amount = 1 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronPlate,
                CraftingTimePerItem = 4,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronIngot, Amount = 2 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronRod,
                CraftingTimePerItem = 4,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronIngot, Amount = 1 }
                }
            });
        }
    }
}
