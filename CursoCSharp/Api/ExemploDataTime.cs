using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploDataTime
    {
        public static void Executar()
        {
            var dataTime = new DateTime(year: 2000, month: 10, day: 07);
            Console.Write(dataTime.Day + "/");
            Console.Write(dataTime.Month + "/");
            Console.WriteLine(dataTime.Year);

            var dateTimeNow = DateTime.Now;
            Console.WriteLine("Dia Atual: " + dateTimeNow);
            Console.WriteLine("Hora Atual: " + dateTimeNow.Hour +":"+ dateTimeNow.Minute + ":" + dateTimeNow.Second);
            Console.WriteLine();
            Console.WriteLine("Amanha: " + dateTimeNow.AddDays(1));
            Console.WriteLine("Ontem: " + dateTimeNow.AddDays(-1));
          
            Console.WriteLine("-----------------------------");
            
            Console.WriteLine("Dia do Mes: " + dateTimeNow.ToString("dd"));
            Console.WriteLine("Data Atual: " + dateTimeNow.ToString("d"));
            Console.WriteLine("Data Atual Por Extenso: " + dateTimeNow.ToString("D"));
            Console.WriteLine();
            Console.WriteLine("Era Atual: " + dateTimeNow.ToString("gg"));
            Console.WriteLine("Data e Hora Atual Abreviado: " + dateTimeNow.ToString("g"));
            Console.WriteLine("Data e Hora Atual Completo: " + dateTimeNow.ToString("G"));
            Console.WriteLine();
            Console.WriteLine("Data Atual Formatado: " + dateTimeNow.ToString("dd/MM/yyyy"));
            Console.WriteLine("Hora Atual Formatado: " + dateTimeNow.ToString("HH:mm"));

        }

    }
}
