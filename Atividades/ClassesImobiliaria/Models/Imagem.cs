using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public int Id_Imovel { get; set; }
        public string? caminho_imagem { get; set; }
    }
}