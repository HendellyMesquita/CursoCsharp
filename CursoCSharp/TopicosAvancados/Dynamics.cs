using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            string msg = "Objeto Recebe. ";

            dynamic Objeto = "Teste";
            Console.WriteLine(msg + Objeto);

            Objeto = 20;
            Console.WriteLine(msg + Objeto);

            Objeto++;
            Console.WriteLine(msg + Objeto);

            Objeto = true;
            Console.WriteLine(msg + Objeto);





        }

    }
}
