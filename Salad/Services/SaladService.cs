using Salad.Models;
using Salad.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.Services
{
    public class SaladService : ISaladService
    {
        public List<Vegetables> FindVegetable(List<Vegetables> vegetables)
        {
            Console.WriteLine("Enter name vegetable for the search");
            string nameVegetable=Console.ReadLine();
            foreach (var vegetable in vegetables)
            {
                if (vegetable.Name == nameVegetable)
                {
                    Console.WriteLine($"Found vegetable: {vegetable.Name}");
                }
            }
            return vegetables;
        }
        public List<Vegetables> SortByParameter(List<Vegetables> vegetables)
    {
            IEnumerable<Vegetables> sortedVegetables =
            from vegetable in vegetables
            orderby vegetable.Name ascending, vegetable.Name ascending
            select vegetable;

            Console.WriteLine("Sorted Salad:");
            foreach (Vegetables vegetable in sortedVegetables)
                Console.WriteLine(vegetable.Name + " " + vegetable.Calories + " " + vegetable.Color);
            int TotalCalories = 0;
            foreach (Vegetables vegetable in vegetables)
            {
                TotalCalories += vegetable.Calories;
            }
            Console.WriteLine($"Calorie content of salad {TotalCalories} kKal");
            return vegetables;
        }
    }
}
