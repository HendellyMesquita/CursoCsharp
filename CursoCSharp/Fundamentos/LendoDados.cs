using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o seu nome ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Salario atual");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} de idade {idade} rescebe R${salario}");
        }

    }
}
