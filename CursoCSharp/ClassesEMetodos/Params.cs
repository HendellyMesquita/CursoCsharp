using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Bom dia {pessoa}");
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Maria", "Ana", "João", "Kaike", "Flavia", "Lucas", "Renata", "Luiz", "Joana", "Pablo", "Padricia");

        }

    }
}
