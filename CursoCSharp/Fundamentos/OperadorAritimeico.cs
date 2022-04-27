using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorAritimeico
    {
        public static void Executar()
        {
            var preco = 1000.0;
            var importo = 355;
            var desconto = 0.1;
            var impar = 25;
            var par = 24;

            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Soma valor ");
            Console.WriteLine();

            var total = preco + importo;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"Valor com desconto {totalComDesconto}");
            Console.WriteLine($"Valor sem desconto {total}");


            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Verifica Impar ou par");
            Console.WriteLine();
            Console.WriteLine("{0}/2 resto {1}, Portanto Par" , par, par%2 );
            Console.WriteLine("{0}/2 resto {1}, Portanto Impar", impar, impar % 2);



            Console.WriteLine("-------------------------------");
            Console.WriteLine("calculo IMC");
            Console.WriteLine();
           
            Console.Write("Peso: ");
            var peso = double.Parse(Console.ReadLine());
           
            Console.Write("Altura: ");
            var altura = double.Parse(Console.ReadLine());

            var resultado = peso / Math.Pow(altura,2);
            var imc = resultado.ToString("F2");

            Console.WriteLine($"IMC e igual a {imc}");
        }

    }
}
