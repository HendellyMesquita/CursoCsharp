using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Sponto
    {
        public int X;
        public int Y;
    }
    public class Cponto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            //ATRIBUIÇÃO POR VALOR
            Sponto sponto = new Sponto { X = 1, Y = 3 };
            Sponto copiasPonto = sponto;
            sponto.X = 3;
            sponto.Y = 6;

            //ATRIBUIÇÃO POR REFERENCIA
            Cponto cponto = new Cponto { X = 2, Y = 4 };
            Cponto copiacPonto = cponto;
            cponto.X = 5;
            cponto.Y = 8;

            Console.WriteLine($"Valor sponto X: {sponto.X}, Valor sponto Y: {sponto.Y}");
            Console.WriteLine($"Copia sponto X: {copiasPonto.X}, Copia sponto Y: {copiasPonto.Y}");

            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine($"Valor cponto X: {cponto.X}, Valor cponto Y: {cponto.Y}");
            Console.WriteLine($"Copia cponto X: {copiacPonto.X}, Copia cponto Y: {copiacPonto.Y}");
        }

    }
}
