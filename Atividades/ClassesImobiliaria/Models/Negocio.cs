using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Negocio(int id, string negocio)
    {
        public int Id { get; set; } = id;
        public string? Tipo_negocio { get; set; } = negocio;
    }
}