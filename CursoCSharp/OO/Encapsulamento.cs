using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CursoCSharp.Biblioteca;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class FilhoNãoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não Reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(SobreNome);
           // Console.WriteLine(NumeroCelular);
            Console.WriteLine(Sotaque);
           // Console.WriteLine(SegredoFamilia);
           // Console.WriteLine(UsaPhotoshop);
        }
    }
    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public new void MeusAcessos()
        {
            Console.WriteLine("Amigo Proximo");
            Console.WriteLine(amigo.InfoPublica);
            // Console.WriteLine(amigo.SobreNome);
            // Console.WriteLine(amigo.NumeroCelular);
            // Console.WriteLine(amigo.Sotaque);
            // Console.WriteLine(amigo.SegredoFamilia);
            // Console.WriteLine(amigo.UsaPhotoshop);
        }
    }
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new FilhoNãoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }

    }
}
