using Module2.Entities;
using Module2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Services.Abstraction
{
     interface IRoomService
     {
        public int CompareTo(ElectroApp? electroApp);
        public int SumPower(List<ElectroEntity> includeApp);
        public List<ElectroEntity> FindApp(List<ElectroEntity> includeApp);
     }
}
