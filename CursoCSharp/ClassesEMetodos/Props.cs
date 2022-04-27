using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        private string nome;
        private double desconto = 0.1;
        public double Preco { get; set; }
        public double PrecoComDesconto { get => Preco - (desconto * Preco); }
        public string Nome { get { return "Opcional: " + nome; } set { nome = value; } }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional()
        {
        }
    }
    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine("Produto " + op1.Nome);
            Console.WriteLine("Preço R$" + op1.Preco);
            Console.WriteLine("Preço com desconto R$" + op1.PrecoComDesconto);

            Console.WriteLine("---------------------------");

            var op2 = new CarroOpcional("Direção Eletrica", 2349.9);
            Console.WriteLine("Produto " + op2.Nome);
            Console.WriteLine("Preço R$" + op2.Preco);
            Console.WriteLine("Preço com desconto R$" + op2.PrecoComDesconto);
        }

    }
}
