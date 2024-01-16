using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models
{
    public class Suite
    {
        public Suite(){}

        public Suite(string tipoSuite, int capacidade, decimal valorDiario){

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiario = valorDiario;
        }


        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiario { get; set; }
    }
}