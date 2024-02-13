using Module2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Repository.Abstraction
{
    interface IRepositoryApp
    {
        public List<ElectroEntity> includedApp();
        public int SumPower(List<ElectroEntity> includeApp);
    }
}
