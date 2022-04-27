using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Biblioteca
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Amigo Proximo");
            Console.WriteLine(amigo.InfoPublica);
           // Console.WriteLine(amigo.SobreNome);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.Sotaque);
           // Console.WriteLine(amigo.SegredoFamilia);
           // Console.WriteLine(amigo.UsaPhotoshop);
            Console.WriteLine("--------------------");
        }
    }
}
