using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Aluno Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();
            bool comportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && comportamento)
                Console.WriteLine("Quadro de honra!");
        }

    }
}
