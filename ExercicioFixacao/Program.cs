using System;
using ExercicioFixacao.Entities;

namespace ExercicioFixacao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pensao pensao = new Pensao();
            
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                pensao.AdicionarResidente(new Residente
                {
                    Nome = nome,
                    Email = email
                }, quarto);
            }

            Console.WriteLine("Quartos ocupados:");
            pensao.MostrarQuartosAlugados();
        }
    }
}