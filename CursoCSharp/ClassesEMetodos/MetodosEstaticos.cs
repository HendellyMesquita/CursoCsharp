using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Subitrair(int a, int b)
        {
            return a - b;
        }

        public static int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            Console.WriteLine("2 + 2 = " + CalculadoraEstatica.Somar(2, 2));
            Console.WriteLine("2 - 2 = " + CalculadoraEstatica.Subitrair(2, 2));
            Console.WriteLine("2 * 2 = " + CalculadoraEstatica.Multiplicar(2, 2));
            Console.WriteLine("2 / 2 = " + CalculadoraEstatica.Dividir(2, 2));

        }

    }
}
