using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecaoList;

namespace CursoCSharp.Colecoes
{
    class ColecaoIgualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.50);
            var p2 = new Produto("Borracha",0.50);
            var p3 = new Produto("Caneta", 1.50);
            var p4 = p2;

            Console.Write("Produto do lote 1 e o mesmo que produto do lote 4? ");
            Console.WriteLine(p1 == p3);
            Console.Write("Produto do lote 5 e o mesmo que produto do lote 2? ");
            Console.WriteLine(p4 == p2);
            Console.Write("Produto do lote 1 e o mesmo que produto do lote 4? ");
            Console.WriteLine(p1.Equals(p3));
            

        }

    }
}
