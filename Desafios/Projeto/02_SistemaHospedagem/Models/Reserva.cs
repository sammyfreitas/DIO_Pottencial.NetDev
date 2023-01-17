using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void cadastrarHospedes(List<Pessoa> hospedes)
        {
                       
            if (Suite.capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {            
                    Console.WriteLine("Número de hóspedes é maior que a capacidade");
            } 
        }

        public void cadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int obterQuantidadeHospedes()
        {

            int numeroH = Hospedes.Count;
                return numeroH;
        }

        public decimal calcularValorDiaria()
        {

            decimal valor = DiasReservados * (Suite.valorDiaria);

            if (DiasReservados >= 10)
            {
                return valor = (valor - valor/10);
            }

            return valor;
        }
    }
}