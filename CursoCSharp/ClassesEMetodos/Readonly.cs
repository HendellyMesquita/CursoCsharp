using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome { get; set; }
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }
  
    class Readonly
    {
        public static void Executar()
        {
            var novocliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));
            Console.WriteLine(novocliente.Nome);
            Console.WriteLine(novocliente.GetDataDeNascimento());
        }

    }
}
