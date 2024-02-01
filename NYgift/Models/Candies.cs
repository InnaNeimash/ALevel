using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NYgift.Models
{
    public class Candies : IComparable<Candies>
    {
        public string Name { get; set; }
        public int Weight { get; }
        public Candies(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public int CompareTo(Candies? candies)
        {
            if (candies is null) throw new ArgumentException("Incorrect parameter value");
            return Weight - candies.Weight;
        }
    }
}