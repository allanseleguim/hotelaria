using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
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

       public void CadastrarHospedes(List<Pessoa> hospedes)
{
    if (hospedes.Count <= 50)
    {
        Hospedes = hospedes;
    }
    else
    {
        throw new Exception("Capacidade excedida. Não é possível acomodar mais de 50 hóspedes.");
    }
}


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implemente a contagem dos hóspedes aqui
            return 0;
        }

      public decimal CalcularValorDiaria()
{
    if (Suite != null)
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
        if (DiasReservados >= 10)
        {
            valor *= 0.9M; // Aplica o desconto de 10%
        }

        return valor;
    }
    return 0;
}

    }
}
