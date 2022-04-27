using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static double Desconto { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public double CalculadoraDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
           // Produto.Desconto = 0.5;

            var caneta = new Produto("Caneta", 3.2, 0.5);
            var borracha = new Produto("Borracha", 5.3, 0.5);

            Console.WriteLine("Preço Caneta com desconto: {0}", caneta.CalculadoraDesconto());
            Console.WriteLine("Preço Borracha com desconto: {0}", borracha.CalculadoraDesconto());
        }
    }
}
