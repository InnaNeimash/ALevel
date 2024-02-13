using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2.Enum;

namespace Module2.Models
{
    public class ElectroApp
    {
        public TypeApp TypeApp { get; set; }
        public string NameApp { get; set; }
        public int Power { get; set; }

        public void Print() 
        {
            Console.WriteLine($"Type appliances {TypeApp}, Name appliances {NameApp}, Power {Power}");
        }
    }
}
