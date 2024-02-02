using Salad.Models;
using Salad.Services.Abstractions;
using Salad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.Repositories;

namespace Salad
{
    public class Startup
    {
        private readonly ISaladService _saladService;
        public Startup(ISaladService saladService)
        {
           _saladService = saladService;
        }
        private readonly SaladRepository _saladRepository;
        public Startup(SaladRepository saladRepository) 
        { 
            _saladRepository = saladRepository;
        }
        public void Start()
        {
            List<Vegetables> vegetables = new List<Vegetables>();
            _saladService.SortByParameter(vegetables);
            _saladService.FindVegetable(vegetables); 
        }
    }
}
