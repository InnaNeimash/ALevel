using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.Repositories;

namespace Salad.Models
{
    public class Vegetables
    {
        public required string Name { get; set; }
        public int Calories { get; set; }
        public required string Color { get; set; }
    }
}
