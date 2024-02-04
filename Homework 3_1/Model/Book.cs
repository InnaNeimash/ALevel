using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1.Model
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Book Id:{Id}| books name {Name}| books Author {Author}| book price {Price}";
        }
    }
}
