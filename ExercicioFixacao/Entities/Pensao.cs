using System;

namespace ExercicioFixacao.Entities
{
    public class Pensao
    {
        public Quarto[] Quartos { get; }

        // n -> número de quartos que serão criados
        public Pensao()
        {
            Quartos = new Quarto[10];
        }

        public void AdicionarResidente(Residente residente, int quarto)
        {
            Quartos[quarto] = new Quarto(residente, quarto);
        }

        public void MostrarQuartosAlugados()
        {
            foreach (var quarto in Quartos)   
            {
                if (quarto != null)
                {
                    Console.WriteLine(quarto);
                }
            }
        }
        
    }
}