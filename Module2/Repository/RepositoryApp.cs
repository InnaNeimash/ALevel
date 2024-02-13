using Module2.Entities;
using Module2.Enum;
using Module2.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2.Entities;

namespace Module2.Repository
{
    public class RepositoryApp:IRepositoryApp
    {
        public List<ElectroEntity> includedApp()
        {
            return new List<ElectroEntity>()
            {
                new ElectroEntity()
                {
                     NameApp="oven",
                     TypeApp=TypeApp.KitchenApp,
                     Power=1500
                },
                new ElectroEntity() 
                {   
                    NameApp="washingMachine",
                    TypeApp=TypeApp.BathroomApp,
                    Power=1500
                },
                new ElectroEntity() 
                {
                    NameApp="TVset",
                    TypeApp =TypeApp.LivingroomApp,
                    Power=300
                }
            };
            
        }
        public int SumPower(List<ElectroEntity>includeApp)
        {
            var TotalPower = includeApp.Select(p => p.Power).Sum();
            return TotalPower;
        }
    } 
}
