
using SatisfactoryCalculator.Logic;
using SatisfactoryCalculator.Logic.Models;
using SatisfactoryCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SatisfactoryCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        CalculatorViewModel viewModel;

        public CalculatorPage(CalculatorViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public CalculatorPage()
        {
            InitializeComponent();

            var item = RecipeBook.GetRecipe(RecipeNames.ModularFrame);

            viewModel = new CalculatorViewModel(item);
            BindingContext = viewModel;
        }
    }
}