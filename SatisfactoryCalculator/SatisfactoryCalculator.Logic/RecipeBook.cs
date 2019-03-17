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
                OutputPerMinute = 60,
                Machine = Machines.Miner,
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronIngot,
                OutputPerMinute = 30,
                Machine = Machines.Smelter,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronOre, InputPerMinute = 30 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronPlate,
                OutputPerMinute = 15,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronIngot, InputPerMinute = 30 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.IronRod,
                OutputPerMinute = 15,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronIngot, InputPerMinute = 15 }
                }
            });
        }
    }
}
