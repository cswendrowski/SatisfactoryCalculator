using System;
using System.Collections.Generic;

namespace SatisfactoryCalculator.Logic.Models
{
    public class Recipe
    {
        public string Name { get; set; }

        public int OutputPerMinute { get; set; }

        public string Machine { get; set; }

        public List<Input> Inputs { get; set; } = new List<Input>();

        public void Should()
        {
            throw new NotImplementedException();
        }
    }
}
