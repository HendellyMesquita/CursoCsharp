using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double nota = 9.7;
            string valor = "25";

            double quebrado = inteiro; //conversão implicita pois um valor int cabe dentro de um double, portanto não possui perda de dados
            int notatruncada = (int)nota; // (CAST) conversão explicita exigida pelo compilador pois ao converter esses valores possui perda de dados
            int valorParce = int.Parse(valor); // conversão explicita exigida pelo compilador pois uma variavel string possui um formato diferente de int
            int valorInt32 = Convert.ToInt32(valor); // conversão explicita exigida pelo compilador pois uma variavel string possui um formato diferente de int

            Console.WriteLine(quebrado);
            Console.WriteLine(notatruncada);
            Console.WriteLine(valorParce);
            Console.WriteLine(valorInt32);

            Console.Write("Informe um valor: ");
            int.TryParse(Console.ReadLine(), out int valorinformado); // Converte uma valor para int, caso não seja um valor valido, retorna 0
            Console.WriteLine(valorinformado);
        }

    }
}
