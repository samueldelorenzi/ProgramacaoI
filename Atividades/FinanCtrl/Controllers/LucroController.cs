using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCtrl.Models;
using FinanCtrl.Repository;

namespace FinanCtrl.Controllers
{

    public class LucroController
    {
        private LucroRepository lucroRepository;
        public LucroController()
        {
            lucroRepository = new LucroRepository();
        }
        public bool Insert(Lucro lucro)
        {
            if (lucroRepository.Save(lucro))
                return true;
            else
                return false;    
        }
        public List<Lucro> Get()
        {
            return lucroRepository.Retrieve();
        }
    }
}