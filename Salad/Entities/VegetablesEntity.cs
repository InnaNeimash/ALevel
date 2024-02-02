using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.Entities
{
    public class VegetablesEntity
    {
        public required string Name { get; set; }
        public int Calories { get; set; }
        public required string Color { get; set; }
    }
}
