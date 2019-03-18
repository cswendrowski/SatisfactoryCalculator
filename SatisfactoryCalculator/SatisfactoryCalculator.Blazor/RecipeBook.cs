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

            AddToBook(new Recipe
            {
                Name = RecipeNames.Screw,
                CraftingTimePerItem = 0.6666666666666666666f,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronRod, Amount = 0.16666666666666f }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.ReinforcedIronPlate,
                CraftingTimePerItem = 10,
                Machine = Machines.Assembler,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronPlate, Amount = 4 },
                    new Input { Name = RecipeNames.Screw, Amount = 24 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.Rotor,
                CraftingTimePerItem = 10,
                Machine = Machines.Assembler,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.IronRod, Amount = 3 },
                    new Input { Name = RecipeNames.Screw, Amount = 22 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.ModularFrame,
                CraftingTimePerItem = 15,
                Machine = Machines.Assembler,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.ReinforcedIronPlate, Amount = 3 },
                    new Input { Name = RecipeNames.IronRod, Amount = 6 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.CopperOre,
                CraftingTimePerItem = 1,
                Machine = Machines.Miner,
            });


            AddToBook(new Recipe
            {
                Name = RecipeNames.CopperIngot,
                CraftingTimePerItem = 2,
                Machine = Machines.Smelter,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.CopperOre, Amount = 1 }
                }
            });


            AddToBook(new Recipe
            {
                Name = RecipeNames.Wire,
                CraftingTimePerItem = 4,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.CopperIngot, Amount = 1 }
                }
            });
            
            AddToBook(new Recipe
            {
                Name = RecipeNames.Cable,
                CraftingTimePerItem = 4,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.Wire, Amount = 2 }
                }
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.Limestone,
                CraftingTimePerItem = 1,
                Machine = Machines.Miner,
            });

            AddToBook(new Recipe
            {
                Name = RecipeNames.Concrete,
                CraftingTimePerItem = 4,
                Machine = Machines.Constructor,
                Inputs = new List<Input>
                {
                    new Input { Name = RecipeNames.Limestone, Amount = 3 }
                }
            });
        }
    }
}
