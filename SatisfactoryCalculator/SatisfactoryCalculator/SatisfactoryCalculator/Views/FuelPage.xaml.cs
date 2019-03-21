
using SatisfactoryCalculator.Logic;
using SatisfactoryCalculator.Logic.Models;
using SatisfactoryCalculator.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SatisfactoryCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuelPage : ContentPage
    {
        FuelViewModel viewModel;

        public FuelPage(FuelViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public FuelPage()
        {
            InitializeComponent();

            viewModel = new FuelViewModel();
            BindingContext = viewModel;
        }

        public void OnClick(object sender, EventArgs e)
        {
            LoadFuel();
        }

        public void LoadFuel()
        {
            viewModel.Amount += viewModel.AmountToLoad;
            if (viewModel.Amount > viewModel.Item.StackSize)
            {
                viewModel.Amount = viewModel.Item.StackSize;
            }
            viewModel.AmountChanged();
        }

        private void Stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            viewModel.AmountChanged();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            viewModel.AmountChanged();
        }
    }
}