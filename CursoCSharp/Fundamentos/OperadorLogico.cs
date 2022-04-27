using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorLogico
    {
        public static void Executar()
        {
            var trabalho1 = true;
            var trabalho2 = false;

            //E, só da verdadeiro quando  as duas exceção for positiva 
            var TV50 = trabalho1 && trabalho2;
            Console.WriteLine($"Possivel comprar TV50? {TV50}");

            //Ou, só da verdadeiro quando uma exceção for positiva 
            var sorvete = trabalho1 || trabalho2;
            Console.WriteLine($"Possivel comprar sorvete? {sorvete}");

            //Ou absoluto, só da verdadeiro quando apenas uma exceção for positiva 
            var TV32 = trabalho1 ^ trabalho2;
            Console.WriteLine($"Possivel comprar TV32? {TV32}");

        }

    }
}
