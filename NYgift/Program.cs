using NYgift.Models;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using NYgift.Services;
using System.ComponentModel.Design;

namespace NYgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var milk_chocolate = new Candies("Milka", 20);
            var white_chocolate = new Candies("Raffaelo", 25);
            var dark_chocolate = new Candies("Trufel", 26);
            var milk_toffee = new Candies("Cow", 15);
            var chocolate_toffee = new Candies("Konfy", 18);
            var cream_toffee = new Candies("Montblanc", 19);
            var orange_jelly = new Candies("Bee orange", 17);
            var berries_jelly = new Candies("Bee berries", 10);
            var kiwi_jelly = new Candies("Bee kiwi", 12);
            var apple_jelly = new Candies("Bee apple", 13);
            var orange_waffles = new Candies("Florence", 23);
            var lemon_waffles = new Candies("Kondik", 22);
            var cranberries_waffles = new Candies("Flora", 20);
            var chocolate_waffles = new Candies("Prime", 28);
           
            Candies[] box = { milk_chocolate , white_chocolate , dark_chocolate , milk_toffee , chocolate_toffee,
            cream_toffee,orange_jelly,berries_jelly,kiwi_jelly,apple_jelly,orange_waffles,lemon_waffles,cranberries_waffles,
            chocolate_waffles};
            Array.Sort(box);
            Console.WriteLine("Sort array to the Weight");
                foreach (Candies candies in box )
                {
                    Console.WriteLine($"{candies.Name}-{candies.Weight}");
                }
            Array.Sort(box, new CandiesComparer());
            Console.WriteLine("Sort array to the Words length");
            int TotalWeight = 0;
                foreach (Candies candies in box)
                {
                    Console.WriteLine($"{candies.Name}-{candies.Weight}");
                    TotalWeight+=candies.Weight;
                }
            Console.WriteLine($"Total weight of the Gift {TotalWeight} g");
            Console.WriteLine("Enter search parameters name candy");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            foreach (Candies candies in box)
            {
                if (candies.Name == str || candies.Weight == weight)
                {
                    Console.WriteLine($"Search result {candies.Name} {candies.Weight}");
                }
            }  Console.WriteLine("Candies not found");     
        }
    }
}
