using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object obj)
        {
            Produto outro = (Produto)obj;
            bool mesmonome = Nome == outro.Nome;
            bool mesmopreco = Preco == outro.Preco;
            return mesmonome && mesmopreco;
        }
        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecaoList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Trone", 49.9);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 49.99),
                new Produto("8° Game of Trone", 49.9),
                new Produto("Poster", 10.50),
            };
            carrinho.AddRange(combo);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("Itens no carrinho: " + carrinho.Count);
            Console.WriteLine("----------------------");

            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
