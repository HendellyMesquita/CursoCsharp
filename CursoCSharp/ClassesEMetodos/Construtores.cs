using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Carro()
        {
        }
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var Bmw = new Carro();
            Bmw.Fabricante = "BMW";
            Bmw.Modelo = "3251";
            Bmw.Ano = 2017;
            Console.WriteLine($"{Bmw.Fabricante}, {Bmw.Modelo}, {Bmw.Ano}");

            /*********************************************************************/

            var Fiat = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019,
            };
            Console.WriteLine($"{Fiat.Fabricante}, {Fiat.Modelo}, {Fiat.Ano}");

            /*********************************************************************/

            var Ford = new Carro("Ford", "Ka", 2017);
            Console.WriteLine($"{Ford.Fabricante}, {Ford.Modelo}, {Ford.Ano}");

        }
    }
}
