using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class ExtruturaIfElse
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota > 7.0)
                Console.WriteLine("Aprovado");
          
            else
                Console.WriteLine("Reprovado");
        }

    }
}
