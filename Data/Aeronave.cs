using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoeAirlines___BlazorVesp.Data
{
    public class Aeronave //um conjunto de objetos
    {
        //Construtor
        public Aeronave(string? modelo, string? codigo, string? fabricante)
        {
            Modelo = modelo;
            Codigo = codigo;
            Fabricante = fabricante;
        }

        //propiedade automatica
        public string? Modelo { get; set; }
        public string? Codigo { get; set; }
        public string? Fabricante { get; set; }
    }
}