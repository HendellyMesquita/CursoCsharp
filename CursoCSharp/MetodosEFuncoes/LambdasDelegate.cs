using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    //delegate define um tipo da assinatura que se espera por retirno 
    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mut = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(sum(45,5));
            Console.WriteLine(sub(32.5,4.5));
            Console.WriteLine(mut(10.2,3));
            Console.WriteLine(div(14.52,3.5));
        }

    }
}
