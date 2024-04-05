using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public double valor { get; set; }
        public int comodos { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Localidade { get; set; }
        public int Id_Negocio { get; set; }

        
    }
}