using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
           DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }

    }
}
