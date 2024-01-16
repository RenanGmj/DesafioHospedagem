using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models
{
    public class Reserva
    {

        public Reserva(){}
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }


        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }



        public void CadastrarHospedes(List<Pessoa>hospedes){
            
            
            
            if(hospedes.Count() <= Suite.Capacidade ){

                Hospedes = hospedes;

            }else{

                throw new ArgumentException("O numero de hospedes ultrapassou a capacidade maxima de nossa suite");
            }



        }

        public void CadastrarSuite(Suite suite){


            Suite = suite;

        }

        public int ObterQuantidadeHospedes(){

            
            return Hospedes.Count();
            
        }

        public decimal ObterValorDiaria(){
            decimal valor = DiasReservados * Suite.ValorDiario;

            if (DiasReservados >= 10)
            {
                
                return valor - (valor * 0.10m);
            }
        
            return valor;
        }
    

            


        
    }
}