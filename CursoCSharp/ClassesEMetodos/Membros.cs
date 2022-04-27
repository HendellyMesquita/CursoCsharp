using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
           
            pessoa.Nome = "Renato";
            pessoa.Idade = 16;
            pessoa.ApresentaNoConsole();

            pessoa.Nome = "Jorge";
            pessoa.Idade = 17;
            var apresentaPessoa = pessoa.Apresentar();
          
            Console.WriteLine( apresentaPessoa.Length);
            Console.WriteLine( apresentaPessoa);


        }

    }
}
