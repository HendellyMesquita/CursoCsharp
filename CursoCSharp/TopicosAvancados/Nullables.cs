using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        static int num3; // variaveis instanciadas no nivel de classe são iniciadas com 0
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;
            bool? bool1 = null;


            if (num1.HasValue)
                Console.WriteLine("Valor de um 1: " + num1);

            else
                Console.WriteLine("valor nullo");

            bool resultado = bool1.GetValueOrDefault();
            int valor = num2 ?? 1000;

            Console.WriteLine(resultado);
            Console.WriteLine(valor);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);

            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
