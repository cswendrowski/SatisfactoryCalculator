using SatisfactoryCalculator.Blazor.Models;
using System.Collections.Generic;

namespace SatisfactoryCalculator.Blazor
{
    public class FuelBook
    {
        private static Dictionary<FuelNames, Fuel> _book = new Dictionary<FuelNames, Fuel>();

        static FuelBook()
        {
            AddToBook(new Fuel
            {
                Name = FuelNames.Leaves,
                Energy = 15,
                StackSize = 500
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Vines,
                Energy = 35,
                StackSize = 200
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Wood,
                Energy = 100,
                StackSize = 100
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Mycelia,
                Energy = 20,
                StackSize = 200
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.AlienCarapace,
                Energy = 250,
                StackSize = 50
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.AlienOrgans,
                Energy = 250,
                StackSize = 50
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Fabric,
                Energy = 15,
                StackSize = 100
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Biomass,
                Energy = 120,
                StackSize = 200
            });

            AddToBook(new Fuel
            {
                Name = FuelNames.Biofuel,
                Energy = 300,
                StackSize = 200
            });
        }

        public static Fuel GetRecipe(FuelNames name)
        {
            return _book[name];
        }

        private static void AddToBook(Fuel fuel)
        {
            _book.Add(fuel.Name, fuel);
        }
    }
}
