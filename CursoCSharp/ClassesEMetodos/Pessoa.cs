using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Apresentar()
        {
            return string.Format($"{Nome} possui {Idade} anos.");
        }
        public void ApresentaNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
