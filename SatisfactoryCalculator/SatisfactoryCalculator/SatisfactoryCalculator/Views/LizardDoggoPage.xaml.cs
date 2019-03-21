
using SatisfactoryCalculator.Logic;
using SatisfactoryCalculator.Logic.Models;
using SatisfactoryCalculator.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SatisfactoryCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LizardDoggoPage : ContentPage
    {
        LizardDoggoViewModel viewModel;

        public LizardDoggoPage(LizardDoggoViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public LizardDoggoPage()
        {
            InitializeComponent();

            viewModel = new LizardDoggoViewModel();
            BindingContext = viewModel;
        }

        public void OnClick(object sender, EventArgs e)
        {
            viewModel.TimesPet++;
        }
    }
}