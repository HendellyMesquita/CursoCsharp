using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i}. ");
            }
            Console.WriteLine();
            double soma = 0;

            Console.WriteLine("informe quantidade de matérias: ");
            int.TryParse(Console.ReadLine(), out int materia);

            for (int i = 1; i <= materia; i++)
            {
                Console.Write($"Infrome a nota da {i} materia: ");
                double.TryParse(Console.ReadLine(), out double notaAtual);

                soma += notaAtual;
            }
            double media = materia > 0 ? soma / materia : 0;
            Console.WriteLine($"Media de notas: {media}");
        }

    }
}
