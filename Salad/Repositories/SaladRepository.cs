using Salad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.Repositories
{
    public class SaladRepository
    {
        public class CreateSalad
        {            
                List<Vegetables> vegetables = new List<Vegetables>
                {
                   new() { Name = "Lettuce",Calories = 10, Color = "Green" },
                   new() { Name = "Carrot", Calories = 20, Color = "Orange" },
                   new() { Name = "Tomatoes", Calories = 20, Color = "Red" },
                   new() { Name = "Cucumber", Calories = 24, Color = "Green" },
                   new() { Name = "Onion", Calories = 25, Color = "Green" },
                   new() { Name = "Pepper", Calories = 30, Color = "Red" },
                   new() { Name = "Eggplant", Calories = 25, Color = "Blue" },
                   new() { Name = "Sunflower oil", Calories = 100, Color = "Colorless" },
                };
        }
    }
}
