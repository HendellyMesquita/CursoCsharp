using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var notacomponto = "notação com ponto ".Insert(18, " são valores seguidos de um .'função sugerida ou uma ação'");
         
            Console.WriteLine( notacomponto);
            Console.WriteLine("o tamanho desse texto e de ".Length);
        }
    }
}
