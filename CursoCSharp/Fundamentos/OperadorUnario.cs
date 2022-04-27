using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorUnario
    {
        public static void Executar()
        {
            var negativo = -5;
            var num1 = 3;
            var num2 = 6;
            var booleano = true;
            Console.WriteLine("Valor inicial " + negativo);
            Console.WriteLine("Valor inicial " + num1);
            Console.WriteLine("Valor inicial " + num2);
            Console.WriteLine("Valor inicial " + booleano);

            num1++;
            num2--;

            Console.WriteLine(-negativo);
            Console.WriteLine(!booleano);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine($"{num1} {num2}");

            /*operação de incremento/decremento informados a esquerda é execultado no começo antes de realizar a operação,
            *enquando quando informado a direita da variavel, so sera execultado no final da operação apos toda a execulsao
            *           EXEMPLO
            * num2 sera decrementado primeiro
            * num1 sera comparado com o novo resultado de num2
            * num1 sera imcrementado 
            * fim da execulsao*/
            Console.WriteLine(num1++ == --num2);
            Console.WriteLine($"{num1} {num2}");

        }

    }
}
