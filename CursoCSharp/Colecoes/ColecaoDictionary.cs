using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem_aranha");
            filmes.Add(2004, "os incrives");
            filmes.Add(2006, "O grande truque");

            if
                (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004 " + filmes[2004]);
                Console.WriteLine("2004 " + filmes.GetValueOrDefault(2004));
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(filmes.ContainsValue("Aminesia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");
            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}");

            Console.WriteLine("----------------------------");
            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            Console.WriteLine("----------------------------");
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("----------------------------");
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} e de {filme.Key}");
            }
            Console.WriteLine("----------------------------");

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} e de {filme.Key}");
            }
        }

    }
}
