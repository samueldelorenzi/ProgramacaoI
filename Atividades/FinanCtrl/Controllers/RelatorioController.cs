using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCtrl.Repository;

namespace FinanCtrl.Controllers
{
    public class RelatorioController
    {
        private RelatorioRepository relatorioRepository;
        public RelatorioController()
        {
            relatorioRepository = new RelatorioRepository();
        }       
        public float RetornarSaldo()
        {
            return relatorioRepository.CalcularSaldo();
        }
    }
}