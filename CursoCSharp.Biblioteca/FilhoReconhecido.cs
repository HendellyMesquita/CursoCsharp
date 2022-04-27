using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Biblioteca
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Filho Reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(SobreNome);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(Sotaque);
            Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaPhotoshop);
            Console.WriteLine("--------------------");

        }
    }
}
