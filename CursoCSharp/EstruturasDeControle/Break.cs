using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 21);

            Console.WriteLine($"Queremos {numero}");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Queremos {i}");

                if (i == numero)
                {
                    Console.WriteLine("Sim");
                    break;
                }

                else
                    Console.WriteLine("Não");
            }

            Console.WriteLine("fim");
        }
    }
}
