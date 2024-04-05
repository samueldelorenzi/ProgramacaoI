using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Imagem(int id, int id_imovel, string imagem)
    {
        public int Id { get; set; } = id;
        public int Id_Imovel { get; set; } = id_imovel;
        public string? Caminho_imagem { get; set; } = imagem;
    }
}