using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        //lambda uma função anonima armazenada em uma variavel
        //action uma função void obrigatoriamente sem retorno
        //func uma função que  obrigatoriamente possui um retorno

        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
             {
                 Random random = new Random();
                 return random.Next(1, 11);
             };
            Console.WriteLine(jogarDado());
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(7, 10, 2000));

        }

    }
}
