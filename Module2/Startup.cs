using Module2.Entities;
using Module2.Models;
using Module2.Repository;
using Module2.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Startup
    {
        private readonly IRoomService _roomService;
        public Startup(IRoomService roomService)
        {
            _roomService = roomService;
        }
        private readonly RepositoryApp _RepositoryApp;
        public Startup(RepositoryApp RepositoryApp)
        {
            _RepositoryApp = RepositoryApp;
        }
        public void Start()
        {
            List<ElectroEntity> includeApp = new List<ElectroEntity>();
            _roomService.SumPower(includeApp);
            _roomService.FindApp(includeApp);
        }
    }
}
