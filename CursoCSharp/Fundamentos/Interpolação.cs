using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            var Nome = "Mateus";
            var Idade = 25;

            // maneiras possiveis para concatenar texto e variaveis

            Console.WriteLine(Nome + " Possui " + Idade + " Anos de vida");
            Console.WriteLine("{0} Possui {1} Anos de vida", Nome, Idade);
            Console.WriteLine($"{Nome} Possui {Idade} Anos de vida");


        }

    }
}
