using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWile
    {
        public static void Executar()
        {
            string entrada;
            do
            {
                Console.WriteLine("Informe seu Nome");
                entrada = Console.ReadLine();
                Console.WriteLine($"Seja bem-vindo {entrada}");
                Console.WriteLine("Novo usuario? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");

            Console.WriteLine("Operação finalizada com sucesso");
        }

    }
}
