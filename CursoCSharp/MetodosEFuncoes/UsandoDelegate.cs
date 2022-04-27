using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimeSoma(double a, double b);

        static double StaticSoma(double a, double b)
        {
            return a + b;
        }
        static void StaticImprimeSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            //possivel associar funções existentes em um delegate quando a assinatura dos dois sao o mesmo
            Soma op1 = StaticSoma;
            Console.WriteLine(op1(2, 3.9));
            ImprimeSoma op2 = StaticImprimeSoma;
            op2(5.4, 8);

            Console.WriteLine("----------------------");

            Func<double, double, double> op3 = StaticSoma;
            Console.WriteLine(op3(2, 3.9));
            Action<double, double> op4 = StaticImprimeSoma;
            op4(5.4, 8);

        }

    }
}
