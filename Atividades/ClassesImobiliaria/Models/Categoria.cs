using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Categoria(int id, string categoria)
    {
        public int Id { get; set; } = id;
        public string? Tipo_categoria { get; set; } = categoria;
    }
}
