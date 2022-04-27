using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            /* "double" armazena valores quebrados
             * "float"  possui metade do armazenamento de um double
             * "int"    armazena valores inteiros
             * "const"  não pode ser alterado em outro local do codigo 
             * "bool"   armazena verdadeiro ou false
             * "byte"   armazena 8bites
             * "sbyte"  armazena valores com sinais
             * "long"   armazena valores estremamente longas
             * "slong"  armazena valores estremamente longas sem sinal
             * "var"    compilador detecta tipo da variavel pelo valor q ela recebe
             */

           // double raio = 4.5;
           // double Pi = 3.14;
           // double area = Pi * raio * raio;
           // Console.WriteLine("Valor da area " + area);
           // Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");

            bool verdadeiro = true;
            bool falso = false;
            Console.WriteLine("bool armazena valoes" + verdadeiro + " e " + falso);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            byte minimoBite = byte.MinValue;
            byte maximoBite = byte.MaxValue;
            Console.WriteLine("variaveis bite armazena valores entre " + minimoBite + " a " + maximoBite);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            sbyte minimosBite = sbyte.MinValue;
            sbyte maximosBite = sbyte.MaxValue;
            Console.WriteLine("variaveis sbite armazena valores entre " + minimosBite + " a " + maximosBite);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            short minimoShort = short.MinValue;
            short maximoShort = short.MaxValue;
            Console.WriteLine("variaveis short armazena valores entre " + minimoShort + " a " + maximoShort);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            long minimoLong = long.MinValue;
            long maximoLong = long.MaxValue;
            Console.WriteLine("variaveis long armazena valores entre " + minimoLong + " a " + maximoLong);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            ulong minimouLong = ulong.MinValue;
            ulong maximouLong = ulong.MaxValue;
            Console.WriteLine("variaveis ulong armazena valores entre " + minimouLong + " a " + maximouLong);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            double minimoDouble = double.MinValue;
            double maximoDouble = double.MaxValue;
            Console.WriteLine("variaveis double armazena valores entre " + minimoDouble + " a " + maximoDouble);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            int minimoint = int.MinValue;
            int maximoint = int.MaxValue;
            Console.WriteLine("variaveis int armazena valores entre " + minimoint + " a " + maximoint);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            float minimofloat = long.MinValue;
            float maximofloat = long.MaxValue;
            Console.WriteLine("variaveis float armazena valores entre " + minimofloat + " a " + maximofloat);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

        }
    }
}
