using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 9; //num1 = valor de num1 + 9
            num1 -= 3; //num1 = valor de num1 - 10
            num1 *= 5; //num1 = valor de num1 * 5
            num1 /= 2; //num1 = valor de num1 / 2
            Console.WriteLine($"{num1} e a soma so seu valor +9 -10 *5 /2");
          
            var a = 10;
            var b = a;
            a++; // a = valor de a + 1
            b--; // b = valor de b - 1
            Console.WriteLine($"10 + 1 = {a} | 10 - 1 = {b}");

        }

    }
}
