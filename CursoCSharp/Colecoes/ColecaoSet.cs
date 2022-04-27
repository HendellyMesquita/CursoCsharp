using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Trone", 49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 49.99),
                new Produto("8° Game of Trone", 49.9),
                new Produto("Poster", 10.50),
            };
            // carrinho.AddRange(combo);
            carrinho.UnionWith(combo);

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome}, R$ {item.Preco}");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Itens no carrinho: " + carrinho.Count);
            Console.WriteLine("----------------------");

            // carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome}, R$ {item.Preco}");
            }
            carrinho.Add(livro);

            Console.WriteLine("----------------------");
            Console.WriteLine("Itens no carrinho: " + carrinho.Count);
            Console.WriteLine("----------------------");
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
