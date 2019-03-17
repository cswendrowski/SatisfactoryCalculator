using SatisfactoryCalculator.Logic.Models;

namespace SatisfactoryCalculator.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }

        public CalculatorViewModel(Recipe item = null)
        {
            Title = item.HumanName;
            Item = item;
        }
    }
}
