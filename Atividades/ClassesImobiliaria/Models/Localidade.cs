using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Localidade(int id, string localidade)
    {
        public int Id { get; set; } = id;
        public string? Tipo_localidade { get; set; } = localidade;
    }
}