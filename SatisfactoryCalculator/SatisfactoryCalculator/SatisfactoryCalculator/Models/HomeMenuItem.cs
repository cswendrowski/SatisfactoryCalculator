using System;
using System.Collections.Generic;
using System.Text;

namespace SatisfactoryCalculator.Models
{
    public enum MenuItemType
    {
        Calculator,
        LizardDoggo,
        BiofuelTimer,
        Map,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
