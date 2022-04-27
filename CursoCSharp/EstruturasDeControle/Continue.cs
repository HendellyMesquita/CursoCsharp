using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Continue
    {
        public static void Executar()
        {
            Random random = new Random();
            int intervalo = random.Next(1, 51);
            Console.WriteLine($"Numeros pares entre 1 e {intervalo}");

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }

        }
    }

}
