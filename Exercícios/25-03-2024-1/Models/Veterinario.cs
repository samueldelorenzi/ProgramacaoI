using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _25_03_2024.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public static string? Nome { get; set; }
        public string? Fone { get; set; }
        public string? CRMV { get; set; }
        public string? Email { get; set; }
    }
}