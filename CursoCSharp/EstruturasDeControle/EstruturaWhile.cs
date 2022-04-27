using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                int.TryParse(Console.ReadLine(), out int palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corOriginal = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("numero sorteado {1} encontrado em {0} tentativas", tentativas, numeroSecreto);
                    Console.BackgroundColor = corOriginal;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Numero secreto é menor que {0}", palpite);
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Numero secreto é maior que {0}", palpite);
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }
        }

    }
}
