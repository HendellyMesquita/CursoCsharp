using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public enum Genero
    {
        Acao,
        Aventura,
        Terror,
        Animacao,
        Comedia,
    };
    public class Filme
    {
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
    }

    class Enumeradores
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.Genero = Genero.Comedia;

            Console.WriteLine($"Filme {filmeParaFamilia.Titulo}, Genero {filmeParaFamilia.Genero}");
        }

    }
}
