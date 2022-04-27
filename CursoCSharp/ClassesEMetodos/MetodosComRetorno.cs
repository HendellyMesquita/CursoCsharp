using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        
        public CalculadoraCadeia Subitrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine("7 + 3 = " + calculadoraComum.Somar(7, 3));
            Console.WriteLine("2 - 7 = " + calculadoraComum.Subtrair(2, 7));
            Console.WriteLine("3 * 4 = " + calculadoraComum.Multiplicar(3, 4));
            Console.WriteLine("6 / 2 = " + calculadoraComum.Dividir(6, 2));

            Console.WriteLine("***********************************************");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(5).Multiplicar(3).Subitrair(1).Dividir(2).Imprimir().Limpar().Imprimir();

            var resultado = calculadoraCadeia.Somar(8).Multiplicar(2).Subitrair(3).Dividir(4).Resultado();
            Console.WriteLine(resultado);
        }

    }
}
