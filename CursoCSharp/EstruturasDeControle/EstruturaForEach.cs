using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Percorre palavra";
            var alunos = new string[] { "1", "2", "3", "4", "5" };

            foreach(var letra in palavra)
            {
                Console.Write($"{letra} | ");
            }

            Console.WriteLine();
            foreach (var aluno in alunos)
            {
                Console.Write($"{aluno}, ");
            }

        }

    }
}
