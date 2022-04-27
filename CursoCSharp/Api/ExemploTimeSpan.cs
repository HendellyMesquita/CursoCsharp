using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 50);
            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);
            Console.WriteLine();

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);
            Console.WriteLine("Tipo; " + tempo.GetType().Name);
            Console.WriteLine("intervalo +10 MINUTOS : " + intervalo.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine("intervalo -10 MINUTOS : " + intervalo.Subtract(TimeSpan.FromMinutes(10)));
            Console.WriteLine();
            Console.WriteLine("Tostring1: " + intervalo.ToString("g"));
            Console.WriteLine("Tostring2: " + intervalo.ToString("G"));
            Console.WriteLine("Tostring3: " + intervalo.ToString("c"));
            Console.WriteLine();
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }

    }
}
