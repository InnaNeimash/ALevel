using Module2.Models;
using Module2.Services.Abstraction;
using Module2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Module2.Entities;
using System.Reflection.Metadata;

namespace Module2.Services
{
    public class RoomService : IRoomService, IComparable<ElectroApp>
    {
        public int CompareTo(ElectroApp? electro)
        {
            if (electro is null) throw new ArgumentException("Incorrect parameter value");
            return electro.Power - electro.Power;
        }
        public List<ElectroEntity> FindApp(List<ElectroEntity> electroEntities)
        {
            Console.WriteLine("Enter name electrical appliance for the search");
            string SearchName = Console.ReadLine();
            Console.WriteLine("Enter power electrical appliance for the search");
            int SearchPower = Convert.ToInt32 (Console.ReadLine());
            foreach (var electroEntity in electroEntities)
            {
                if (electroEntity.NameApp == SearchName && electroEntity.Power<SearchPower)
                {
                    Console.WriteLine($"Found electrical appliance: {electroEntity.NameApp}");
                }
            }
            return electroEntities;
        } 
        public int SumPower(List<ElectroEntity> includeApp)
        {
            var TotalPower = includeApp.Select(p => p.Power).Sum();
            return TotalPower;
        }
    }
}