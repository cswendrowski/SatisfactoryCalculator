namespace SatisfactoryCalculator.Blazor.Models
{
    public class Fuel
    {
        public FuelNames Name { get; set; }

        public int StackSize { get; set; }

        public int Energy { get; set; }

        public double BurnTimeInSeconds => 0.05 * Energy;

        public double GetRemainingSeconds(int amount)
        {
            return BurnTimeInSeconds * amount;
        }
    }
}
