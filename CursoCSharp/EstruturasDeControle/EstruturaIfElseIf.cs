using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Informe a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota > 7.0)
                Console.WriteLine("Aprovado");

            else if (nota >= 6 && nota <= 7)
                Console.WriteLine("Aprovação depende do conselho");

            else
                Console.WriteLine("Reprovado");
        }

    }
}
