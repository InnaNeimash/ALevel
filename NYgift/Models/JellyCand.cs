using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYgift.Models
{
    public class JellyCand:Candies
    {
        new public int Weight = 10;

        public JellyCand(string name, int weight) : base(name, weight)
        {
        }
    }
}
