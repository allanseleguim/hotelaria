using System;
using System.Collections.Generic;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de reservas de hotel!");

            // Solicita o número de hóspedes
            Console.Write("Quantos hóspedes serão? ");
            int numeroHospedes = int.Parse(Console.ReadLine());

            // Solicita o valor da diária
            Console.Write("Qual é o valor da diária da suíte? ");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            // Cria a lista de hóspedes
            List<Pessoa> hospedes = new List<Pessoa>();
            for (int i = 0; i < numeroHospedes; i++)
            {
                Console.Write($"Digite o nome do hóspede {i + 1}: ");
                string nomeHospede = Console.ReadLine();
                hospedes.Add(new Pessoa(nomeHospede));
            }

            // Cria a suíte
            Suite suite = new Suite("Suíte Executiva", 2, valorDiaria);

            // Cria a reserva
            Console.Write("Por quantos dias deseja reservar? ");
            int diasReservados = int.Parse(Console.ReadLine());
            Reserva reserva = new Reserva(diasReservados);
            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarSuite(suite);

            // Calcula e exibe o valor total
            decimal valorTotal = reserva.CalcularValorDiaria();
            Console.WriteLine($"O valor total da reserva é: {valorTotal:C}");

            Console.WriteLine("Obrigado por usar nosso sistema de reservas!");
        }
    }
}
