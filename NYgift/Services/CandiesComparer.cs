using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NYgift.Models;

namespace NYgift.Services
{
    public class CandiesComparer : IComparer<Candies>
    {
        public int Compare(Candies? p1, Candies? p2)
        {
            if (p1 is null || p2 is null) throw new ArgumentException("Incorrect parameter value");
            return p1.Name.Length - p2.Name.Length;
        }
    }
}
