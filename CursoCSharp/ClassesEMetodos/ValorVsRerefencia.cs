using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    //public struct Dependente
    //{
    //    public string Nome;
    //    public int Idade;

    //}

    public class Dependente
    {
        public string Nome;
        public int Idade;

    }
    class ValorVsRerefencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dependente = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };
            Dependente copiadependente = dependente;
            Console.WriteLine($"{dependente.Nome} {dependente.Nome}");
            Console.WriteLine($"{copiadependente.Idade} {copiadependente.Idade}");
            copiadependente.Nome = "Renato";
            dependente.Idade = 21;

            Console.WriteLine($"{dependente.Nome} {dependente.Nome}");
            Console.WriteLine($"{copiadependente.Idade} {copiadependente.Idade}");
        }

    }
}
