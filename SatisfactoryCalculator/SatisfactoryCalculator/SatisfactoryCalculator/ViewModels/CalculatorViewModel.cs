using Humanizer;
using SatisfactoryCalculator.Logic;
using SatisfactoryCalculator.Logic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace SatisfactoryCalculator.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public List<string> Recipes { get; set; }

        public Recipe Item { get; set; }

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
                var name = (RecipeNames) Enum.Parse(typeof(RecipeNames), value.Dehumanize());
                Item = RecipeBook.GetRecipe(name);
                PopulateNeeds();
                this.OnPropertyChanged(nameof(Item));
                this.OnPropertyChanged(nameof(MachineNeeds));
                this.OnPropertyChanged(nameof(ResourceNeeds));
            }
        }

        public ObservableCollection<NeedItem> MachineNeeds { get; set; }

        public ObservableCollection<NeedItem> ResourceNeeds { get; set; }

        public CalculatorViewModel(Recipe item = null)
        {
            Recipes = Enum.GetNames(typeof(RecipeNames))
                .Where(x => x != "Unset")
                .Select(x => x.Humanize().Transform(To.TitleCase))
                .ToList();
            Title = item.HumanName;
            ItemName = item.HumanName;
        }

        private void PopulateNeeds()
        {
            var needs = RecipeCalculator.CalculateRecipeNeeds(Item);

            MachineNeeds = new ObservableCollection<NeedItem>();
            ResourceNeeds = new ObservableCollection<NeedItem>();

            foreach (var machineNeed in needs.TotalMachineNeeds)
            {
                MachineNeeds.Add(new NeedItem
                {
                    Name = $"{machineNeed.Key.Humanize().Transform(To.TitleCase)}: {machineNeed.Value}"
                });
            }
            foreach (var resourceNeed in needs.TotalResourceNeeds)
            {
                ResourceNeeds.Add(new NeedItem
                {
                    Name = $"{resourceNeed.Key.Humanize().Transform(To.TitleCase)}: {resourceNeed.Value}"
                });
            }
        }
    }

    [DebuggerDisplay("{Name}")]
    public class NeedItem
    {
        public string Name { get; set; }

        public string Image { get; set; }
    }
}
