using Humanizer;
using SatisfactoryCalculator.Blazor;
using SatisfactoryCalculator.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xamarin.Forms;

namespace SatisfactoryCalculator.ViewModels
{
    public class FuelViewModel : BaseViewModel
    {
        public int AmountToLoad { get; set; } = 0;

        private Timer Timer;

        public int Amount { get; set; } = 0;

        public string Loaded => $"{Amount} Loaded out of {Item.StackSize} maximum";

        public string SecondsUntilEmpty => $"{Item.GetRemainingSeconds(Amount)} Seconds until empty";

        private string _itemName = "";
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                var name = (FuelNames)Enum.Parse(typeof(FuelNames), value.Dehumanize());
                Item = FuelBook.GetRecipe(name);
                Timer.Change(TimeSpan.FromSeconds(Item.BurnTimeInSeconds), TimeSpan.FromSeconds(Item.BurnTimeInSeconds));
            }
        }

        public void AmountChanged()
        {
            this.OnPropertyChanged(nameof(Amount));
            this.OnPropertyChanged(nameof(SecondsUntilEmpty));
            this.OnPropertyChanged(nameof(Loaded));
            this.OnPropertyChanged(nameof(AmountToLoad));
        }

        public Fuel Item { get; set; }

        public List<string> Recipes { get; set; }

        public FuelViewModel()
        {
            Recipes = Enum.GetNames(typeof(FuelNames))
               .Where(x => x != "Unset")
               .Select(x => x.Humanize().Transform(To.TitleCase))
               .ToList();
            Timer = new Timer(OnTimer);

            ItemName = "Leaves";
        }

        void OnTimer(object state)
        {
            if (Amount > 0)
            {
                Amount--;
                // TODO: Notify
                this.OnPropertyChanged(nameof(Amount));
                this.OnPropertyChanged(nameof(SecondsUntilEmpty));
                this.OnPropertyChanged(nameof(Loaded));
            }
        }
    }
}
