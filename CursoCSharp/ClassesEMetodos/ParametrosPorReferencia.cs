using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 500;
            numero = numero + 1500;
        }
        public static void Executar()
        {
            int a = 300;
            AlterarRef(ref a);
            Console.WriteLine(a);

            AlterarOut(out int b);
            Console.WriteLine(b);

        }

    }
}
