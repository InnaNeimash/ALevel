using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYgift.Models;
using System.Threading.Tasks;

namespace NYgift.Models
{
    public class ChocolateCand:Candies
    {
        public byte PercentageChocolate {  get; set; }

        new public byte Weight = 20;

        public ChocolateCand(string name, int weight) : base(name, weight)
        {
        }
    }
}
